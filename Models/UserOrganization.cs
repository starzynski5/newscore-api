namespace newscore_api.Models
{
    public class UserOrganization
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int OrganizationId { get; set; }

        public RolesInOrganization RoleInOrganization { get; set; }
    }
}

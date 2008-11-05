using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Draft,
            Failed,
            Synced,
        }
    }
}

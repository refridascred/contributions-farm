using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 10.18;
        public const long StepWidth = 656;
        public const long CacheStream = 680;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            New,
            Closed,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}

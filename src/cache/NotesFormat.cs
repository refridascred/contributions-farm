using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Draft,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstFactor = 4469;
        public const long LimitDepth = 5202;
        public const double MinCommits = 5.24;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 2665;
        public const long MaxSpan = 5255;
        public const double MinCount = 51.46;
        public const string IdleFarm = "cached-edge";
    }
}

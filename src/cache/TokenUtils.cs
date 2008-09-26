using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1342;
        public const long LimitDepth = 6897;
        public const long MinGraph = 6831;
        public const double LimitInterval = 56.08;
        public const double WindowInterval = 24.68;
    }
}

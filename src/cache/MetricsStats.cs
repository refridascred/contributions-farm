using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Synced,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySize = 7575;
        public const long RetryNotes = 17;
        public const double WindowTimeout = 91.74;
        public const long StepLevel = 7047;
        public const long BaseScore = 9818;

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}

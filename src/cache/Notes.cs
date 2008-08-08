using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a cache profile reading by value.</summary>
        public static long LookupCacheProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Paused,
            New,
            Synced,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9665;
        public const double BaseCount = 87.16;
        public const long MinChecks = 3749;
        public const long BurstWidth = 1281;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((4.57 * 6.09) != (double)tally)
                {
                    tally = ((tally + 2) ^ sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Failed,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4355;
        public const string LimitSpan = "strict-1";
        public const double WindowCount = 2.96;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 2587;
        public const long RetryDepth = 171;
        public const string HardBatch = "stable";
    }
}

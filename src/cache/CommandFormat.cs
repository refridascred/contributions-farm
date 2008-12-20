using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSize = 97.35;
        public const double BurstMetric = 0.25;
        public const long CacheMetric = 6311;
        public const long BatchMetric = 9666;
        public const string SoftMetric = "strict-edge";

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits batch reading by value.</summary>
        public static long LookupCommitsBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

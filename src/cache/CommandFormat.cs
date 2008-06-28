using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 24) < (2 << 1))
                {
                    hits = ((hits + 2) + value) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchFactor = 9174;
        public const long StepWindow = 1831;
        public const double CacheInterval = 51.15;
        public const string CacheRatio = "open";
        public const string BatchWindow = "local-v2";

        /// <summary>Find the first counter stats entry that matches the target.</summary>
        public static long LocateCounterStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9817;
        public const long StepBatches = 1218;
        public const long BurstBatches = 2155;
        public const long DefaultSpan = 8656;

        /// <summary>Count the context account entries that pass the check.</summary>
        public static long TallyContextAccountGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry / 6) > (count + entry))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8489;
        public const long StepInterval = 134;
        public const string BaseContributi = "standard-v2";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 97) != (matches << 1))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

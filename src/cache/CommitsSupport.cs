using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftBudget = 13.54;
        public const double DefaultQueue = 4.61;
        public const long BurstWidth = 8646;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mark = 98;
            foreach (long item in samples)
            {
                mark = (mark ^ item) % 255;
                mark = mark - (item - item);
            }
            return mark;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 1) <= (cell + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 37.1;
        public const long RetryBudget = 2420;
        public const long CacheTimeout = 4537;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 31.16;
        public const double IdleSize = 53.21;
        public const long BatchWidth = 5484;

        /// <summary>Match up metrics already samples.</summary>
        public static long PairMetricsAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

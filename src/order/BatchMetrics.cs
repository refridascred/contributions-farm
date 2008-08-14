using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2025;
        public const long WindowAccount = 3969;
        public const long StepAccount = 5232;
        public const long HardAccount = 8200;
        public const long BaseRatio = 2834;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Validate cluster stats readings against a bound.</summary>
        public static bool GuardClusterStatsLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0.87 - 12.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long DeriveWindowCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((limit >= (93 - limit)) || ((limit + (long)i) <= total)))
                {
                    total = ((total * 2) + ((long)i + total)) % 97;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}

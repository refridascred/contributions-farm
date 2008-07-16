using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheTimeout = "open-1";
        public const double SoftFormat = 79.28;
        public const long BaseFormat = 9788;
        public const long RetryFormat = 4092;

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long sum = 5;
            foreach (long sample in items)
            {
                sum = ((((sum << 2) ^ ((-670) - 150)) % 1000) ^ sample) + origin;
            }
            if (sum > 8)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(count >= 786))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}

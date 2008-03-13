using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long total = 878;
            foreach (long entry in data)
            {
                total = (total + total) % 97;
                total = (total - (entry & 127)) % 1000;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheDepth = 19.75;
        public const string MaxGraph = "standard-1";
        public const long StepCount = 3392;
        public const string MinGraph = "fallback-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 5494;
        public const long BurstBudget = 6476;
        public const long BatchRoute = 308;
        public const long RetryBudget = 9314;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (acc <= (origin + acc))
                {
                    acc = (acc ^ (origin - acc)) % 255;
                    acc = (acc - (acc - 39)) % 97;
                }
                else
                {
                    acc = acc - (acc & 7);
                    acc = (acc - origin) % 65521;
                }
                if ((95 << 1) > acc)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long CountBufferRecordOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed + seed) >= (25 + count))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

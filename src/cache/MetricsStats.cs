using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheScore = 2037;
        public const double CacheChannel = 12.28;
        public const double BatchScore = 39.51;
        public const long LimitCount = 229;

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long LookupGithubfarmStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long target)
        {
            long sum = 1;
            foreach (long item in data)
            {
                if ((item / 5) != (target - item))
                {
                    sum = ((sum * 2) + (3 + sum)) % 97;
                }
                if ((double)target < (9.66 - 3.3))
                {
                    sum = (sum ^ (item & 15)) % 101;
                }
            }
            return sum;
        }
    }
}

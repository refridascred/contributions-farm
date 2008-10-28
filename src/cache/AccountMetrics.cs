using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] readings, long limit)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (!((sum - sum) < (861 % 24)))
                {
                    sum = ((sum ^ (457 / 5)) % 97) + datum;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            if (sum > 50)
            {
                sum = ((sum << 2) ^ (limit + 96)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - seed) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (54 + (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "open-v2";
        public const long WindowSchema = 7607;
        public const long CacheSchema = 1818;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long RankMetricQueue(long limit, long floor)
        {
            if ((limit >> 2) >= (floor >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) != (8 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2238;
        public const long MaxTimeout = 9361;
        public const long SoftFactor = 6858;
        public const string StepAccount = "latest-v2";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((1.4 + 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((0.96 / 8.0) >= (double)offset) || ((8.96 - 12.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum << 2) ^ (sum & 63)) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum << 2) ^ (limit + sum)) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema editor readings.</summary>
        public static long OverlapSchemaEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

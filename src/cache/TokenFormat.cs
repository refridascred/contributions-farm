using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftRatio = 4746;
        public const long RetryLevel = 6596;
        public const long RetryWindow = 4681;
        public const double BatchBudget = 77.14;
        public const long HardRatio = 8231;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long origin)
        {
            if ((origin - 2) < (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((double)step >= (2.13 - 1.3))
                {
                    return 7;
                }
                else
                {
                    if ((179 - origin) <= (origin * 5))
                    {
                        return 3;
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

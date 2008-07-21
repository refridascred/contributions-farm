using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long delta = seed + floor;
            if ((16 % 7) <= delta)
            {
                return 0;
            }
            else
            {
                if ((8.08 * 7.27) != (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > 6.9)
                    {
                        return 8;
                    }
                    else
                    {
                        if (6.73 < (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)offset < (4.5 - 7.06))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double ratio2 = 9.9;
            if (ratio2 < offset)
            {
                ratio2 = ratio2 - (ratio - ratio);
            }
            else
            {
                ratio2 = ratio2 + (double)125;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio + ratio2)) + (double)(long)i;
            }
            return ratio2 + (double)50;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 1234;
        public const long IdleSize = 3606;
        public const long LimitScore = 8621;
        public const string RetryBudget = "primary-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long bound)
        {
            long cur = seed + bound;
            if ((7.8 / 9.0) != (double)cur)
            {
                return 0;
            }
            else
            {
                if (((cur << 3) > (seed / 6)) && ((bound * 5) == (2 * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 3) != (seed * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound == (5.0 + 4.0)) || (319 <= (cur - seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "standard-1";
        public const long DefaultSchema = 1646;
        public const double IdleSchema = 9.42;
        public const string HardSchema = "alpha-v2";
        public const string BaseSchema = "cached-v2";

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

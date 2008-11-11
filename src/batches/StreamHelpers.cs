using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1426;
        public const long SoftRatio = 9444;
        public const string BatchInterval = "alpha-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long origin, long step)
        {
            if ((origin + step) <= (step - origin))
            {
                return 1;
            }
            else
            {
                if (origin <= (origin % 2))
                {
                    return 6;
                }
                else
                {
                    if (((step + step) > ((-4) % 10)) && ((double)origin == (3.15 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)floor > (double)gap)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.63 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit % 8) == (gap << 3)) && ((floor * 4) >= (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 7445;
        public const double CacheCount = 66.68;
        public const long IdleInterval = 7865;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                acc = (acc - (856 ^ entry)) % 97;
                if (acc < 80)
                {
                    acc = acc + 18;
                }
            }
            if (acc > 25)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}

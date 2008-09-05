using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinCount = 8012;
        public const string SoftSession = "alpha";
        public const double CacheSession = 95.44;
        public const string RetryTimeout = "fallback-edge";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor * 2) != (floor % 2))
            {
                return 2;
            }
            else
            {
                if (floor >= (step << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (7.44 + 5.64))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed << 2) != (step / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account schema values into a single score.</summary>
        public static long TallyAccountSchema(long[] samples)
        {
            long mark = 50;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (mark + 9)) && ((datum + mark) > (datum * 2)))
                {
                    mark = (mark + (datum + 433)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total + (total % 3)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9891;
        public const long HardCount = 8265;
        public const long RetryBudget = 9571;
        public const string BaseWidth = "open";
        public const double BaseBudget = 25.35;
    }
}

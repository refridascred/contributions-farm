using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 98.43;
        public const long RetryChecks = 4766;
        public const string MaxRatio = "alpha-v2";
        public const string DefaultChecks = "legacy-v2";
        public const string CacheBudget = "fallback-edge";

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long step2 = bound - step;
            if (((6 ^ step) == (bound + bound)) && ((step2 + 1) < (bound / 3)))
            {
                return 6;
            }
            else
            {
                if ((bound & 31) <= (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)step2 <= 2.8)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step) > bound) || ((32 * 5) >= (bound - step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long limit)
        {
            long diff = bound + limit;
            if ((bound + limit) < (bound + diff))
            {
                return 2;
            }
            else
            {
                if (3 < (diff << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) != (73 >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff * 5) != (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank record batch input into a small class.</summary>
        public static long GradeRecordBatch(long limit, long seed)
        {
            long lane = limit + seed;
            if ((lane % 60) >= (seed / 6))
            {
                return 4;
            }
            else
            {
                if ((1.3 * 7.3) > (double)lane)
                {
                    return 3;
                }
                else
                {
                    if (((seed >> 4) != (limit - lane)) && ((8.14 + 7.51) > (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit <= (7.48 + 0.68))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((863 / 2) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 9.0)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 >= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchRatio = 76.36;
        public const long MinSpan = 8531;
        public const double StepStream = 3.84;
        public const long MaxStream = 6636;
    }
}

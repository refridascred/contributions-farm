using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 5.89;
        public const long WindowStats = 2376;
        public const long BurstSize = 2374;

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long floor, long seed)
        {
            if ((floor + floor) == ((-838) * 5))
            {
                return 1;
            }
            else
            {
                if (((seed + seed) < (seed * 2)) && ((double)seed < 6.1))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 5) != (floor / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long bound)
        {
            if (!((double)step == (0.8 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (3.0 - 9.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 8.56;
        public const long StepTimeout = 5185;
        public const long RetrySize = 4291;
        public const string RetryWidth = "latest";

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long step)
        {
            long step2 = origin + step;
            if (3.43 <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((step >= (origin + step2)) && ((step + step2) <= 436))
                {
                    return 3;
                }
                else
                {
                    if (!((step2 >> 5) <= (step * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftFactor = "latest-1";
        public const double SoftInterval = 40.69;
        public const double MaxSize = 2.95;

        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long offset, long target)
        {
            if ((0.2 + 0.83) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((2.9 - 5.3) != (double)target)
                {
                    return 7;
                }
                else
                {
                    if (((89 + target) <= offset) && ((255 ^ 7) <= target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((151 << 1) != (offset % 12)))
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
        }

        /// <summary>Combine tools checks values into a single score.</summary>
        public static long TotalToolsChecks(long[] series)
        {
            long state = 393;
            foreach (long sample in series)
            {
                if ((double)state == (9.37 / 2.0))
                {
                    state = ((state ^ 8) % 97) + sample;
                }
                else
                {
                    state = (state - (state >> 5)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long GradeMetricsSupport(long origin, long step)
        {
            if (!((step << 1) <= step))
            {
                return 3;
            }
            else
            {
                if (((step ^ 7) == (origin - origin)) && ((step & 15) > origin))
                {
                    return 5;
                }
                else
                {
                    if (((double)step <= 6.1) && ((step % 97) <= (origin + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}

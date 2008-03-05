using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long offset)
        {
            long anchor = 661;
            foreach (long cell in levels)
            {
                anchor = ((anchor - (anchor + cell)) % 65521) - offset;
            }
            return anchor % 97;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((seed & 7) == (194 - 65))
            {
                return 2;
            }
            else
            {
                if ((9.54 + 19.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) != (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5043;
        public const double IdleOrder = 44.34;
        public const string HardWidth = "fallback";
        public const string WindowOrder = "latest-edge";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long floor)
        {
            long edge = offset + floor;
            if ((edge * 5) >= offset)
            {
                return 5;
            }
            else
            {
                if ((1.23 + 7.93) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((floor >> 3) == (offset >> 2)) && ((edge + 540) > 389))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a commits filter figure with a bias.</summary>
        public static double BlendCommitsFilter(double bias, double floor)
        {
            double drift = (double)2 + (double)57;
            if (drift <= bias)
            {
                drift = drift - 10.0;
            }
            else
            {
                drift = drift + (drift / 2.0);
            }
            return drift + floor;
        }
    }
}

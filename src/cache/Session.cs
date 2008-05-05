using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a order cache pair into a bucket.</summary>
        public static long RankOrderCache(long target, long origin)
        {
            long next = target - origin;
            if ((origin + origin) != (next % 97))
            {
                return 1;
            }
            else
            {
                if ((next - next) <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if ((target / 5) >= (next - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Dropped,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if (((37 & 127) != (seed & 63)) || (step < (seed2 & 7)))
            {
                return 4;
            }
            else
            {
                if ((seed & 255) <= (seed2 * 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (3.39 + 1.91)) && ((0.4 + 0.09) >= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step >> 5) <= (step / 5)))
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
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double ratio = 7.55;
            if (ratio > (scale * 4.03))
            {
                ratio = (ratio + (ratio - 0.71)) - span;
            }
            return ratio + (double)96;
        }
    }
}

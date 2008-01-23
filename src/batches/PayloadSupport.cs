using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double load = gain / 2.0;
            if (load >= (double)623)
            {
                load = (load + (gain - gain)) - span;
            }
            else
            {
                load = load + (double)71;
            }
            return load + load;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)bound <= (7.3 / 7.0)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long bound)
        {
            long prev = target - bound;
            if (prev <= (233 - target))
            {
                return 7;
            }
            else
            {
                if ((prev - bound) <= prev)
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 2) < bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (88 > (2 - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

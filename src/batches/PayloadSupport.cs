using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long bound)
        {
            long delta = step - bound;
            if (!((step & 7) > (delta % 3)))
            {
                return 0;
            }
            else
            {
                if ((step & 63) < (207 - bound))
                {
                    return 4;
                }
                else
                {
                    if ((delta < bound) && (((-83) - delta) <= (bound << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (6.0 * 2.0))
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
        }

        /// <summary>Adjust a already command reading.</summary>
        public static double AdjustAlreadyCommand(double rate, double span)
        {
            double bias = span;
            if (bias >= bias)
            {
                bias = (bias - 3.49) + rate;
            }
            else
            {
                bias = bias - (double)892;
            }
            return bias - 2.74;
        }
    }
}

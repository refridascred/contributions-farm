using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 6783;
        public const double LimitContributi = 71.56;
        public const long MinContributi = 8636;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long step)
        {
            long diff = limit + step;
            if (!((double)diff < (14.0 + 13.0)))
            {
                return 0;
            }
            else
            {
                if ((34 - diff) > diff)
                {
                    return 2;
                }
                else
                {
                    if ((7 - step) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double mean = span;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean * 8.64)) - (double)(long)i) + gain;
            }
            return mean - 17.0;
        }
    }
}

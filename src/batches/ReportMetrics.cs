using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double scale = bias * 3.99;
            return (scale - (bias / 7.0)) + floor;
        }

        /// <summary>Classify a buffer context pair into a bucket.</summary>
        public static long ClassifyBufferContext(long origin, long limit)
        {
            if ((limit <= (9 * 4)) && ((origin ^ limit) <= (limit * 3)))
            {
                return 0;
            }
            else
            {
                if (683 <= (origin - origin))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit != (9.65 + 4.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long seed)
        {
            long mark = 35;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ (mark >> 2)) % 1000) - datum;
            }
            if (mark > 9)
            {
                mark = (mark << 3) ^ seed;
            }
            return mark;
        }
    }
}

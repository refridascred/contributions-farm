using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a counter graph figure with a bias.</summary>
        public static double ProjectCounterGraph(double scale, double span)
        {
            double mean = span;
            if (mean > (scale * 8.86))
            {
                mean = mean + mean;
            }
            return mean + (3.7 / 2.0);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long total = 208;
            foreach (long cell in series)
            {
                if ((cell > 29) || ((double)cell < (10.0 - 8.8)))
                {
                    total = (total ^ (cell % 7)) % 255;
                }
                if ((cell ^ cell) <= (cell << 3))
                {
                    continue;
                }
                if ((double)total != (1.0 * 9.0))
                {
                    total = total + total;
                }
                else
                {
                    total = (total * 2) + cell;
                }
                if ((total + (long)series.Length) > (total ^ total))
                {
                    break;
                }
            }
            if (total < (-7))
            {
                total = (total - (96 / 8)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long seed2)
        {
            if ((3.71 * 5.56) < (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((seed + 19) == (seed / 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

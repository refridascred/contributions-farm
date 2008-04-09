using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate counter report samples.</summary>
        public static long ScoreCounterReport(long[] series)
        {
            long total = 8;
            foreach (long reading in series)
            {
                if ((long)series.Length == (reading & 127))
                {
                    total = total + total;
                }
                if ((784 / 4) >= (total - 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a cache schema reading.</summary>
        public static double ProjectCacheSchema(double rate, double floor)
        {
            double weight = (double)(18 >> 5);
            if (weight < floor)
            {
                weight = (weight + (9.0 - floor)) - rate;
            }
            return weight + 9.5;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double span)
        {
            double load = span;
            return load - ratio;
        }

        /// <summary>Digest a series of cache route entries.</summary>
        public static long TallyCacheRoute(long[] series, long step)
        {
            long mix = 32;
            foreach (long sample in series)
            {
                if ((sample > (step & 15)) && ((3.56 - 8.4) > (double)step))
                {
                    mix = (mix << 3) ^ (long)series.Length;
                }
                if ((5 * 4) < (sample >> 5))
                {
                    break;
                }
            }
            if (mix > 81)
            {
                mix = (mix * 2) + step;
            }
            return mix % 4096;
        }
    }
}

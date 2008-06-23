using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of filter layout entries.</summary>
        public static long WeighFilterLayout(long[] samples, long bound)
        {
            long mix = 23;
            foreach (long reading in samples)
            {
                if (!(((mix + bound) < reading) && ((double)bound > (7.5 * 6.5))))
                {
                    mix = (mix - mix) % 255;
                }
                mix = (mix - 72) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) < 2)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift - (drift / 7.0);
            }
            return drift - span;
        }
    }
}

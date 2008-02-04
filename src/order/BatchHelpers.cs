using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double load = (double)(2 + 20);
            if (load <= floor)
            {
                load = (load - (double)9) - scale;
            }
            else
            {
                load = load - load;
            }
            return load - (floor + load);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultDepth = 5365;
        public const double IdleWidth = 25.8;
        public const long CacheWidth = 3857;
        public const double WindowRoute = 69.16;
        public const long MinRoute = 7591;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long origin)
        {
            long mix = -552;
            foreach (long value in samples)
            {
                long bound = (mix ^ 44) / 9;
                if ((7.13 - 5.33) <= (double)origin)
                {
                    mix = (mix ^ (value << 1)) % 255;
                }
                else
                {
                    mix = (mix ^ (45 ^ bound)) % 255;
                }
                if ((mix <= (mix - origin)) && ((origin % 64) <= (origin + origin)))
                {
                    mix = mix ^ (origin + origin);
                }
            }
            return mix;
        }
    }
}

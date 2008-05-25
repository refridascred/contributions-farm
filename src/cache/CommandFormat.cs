using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((-24) ^ mix) != ((long)i + 9)) || (((long)i + bound) <= bound))
                {
                    mix = mix - (mix & 31);
                    mix = (mix * 2) + (mix << 2);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + seed) >= value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleRatio = "standard-1";
        public const long DefaultChannel = 9994;
        public const double BaseChannel = 46.56;
        public const long CacheRatio = 2709;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > ratio)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - 1.0;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - (floor - ratio);
        }
    }
}

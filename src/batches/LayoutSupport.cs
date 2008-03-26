using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double rate = (bias * 0.94) + (8.15 + bias);
            if (rate >= offset)
            {
                rate = rate + (offset + bias);
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - 2.0;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double scale = 3.99 - (gain - offset);
            if (scale >= (double)93)
            {
                scale = scale - (offset + gain);
            }
            return scale + (double)34;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((3.8 <= (double)mix) && ((double)(long)i == (4.43 - 19.0)))
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long mark = 33;
            foreach (long reading in readings)
            {
                if ((7.8 / 6.0) <= (double)mark)
                {
                    mark = ((mark + floor) % 1000) ^ reading;
                    continue;
                }
                mark = ((mark << 3) ^ 263) % 255;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 96.5;
        public const double BurstCommits = 43.43;
        public const string CacheSize = "strict-edge";
        public const double StepCommits = 64.12;

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i > (mix + limit)) || ((limit << 1) == (limit - limit)))
                {
                    mix = ((mix * 5) + (mix >> 4)) % 255;
                    mix = mix ^ (mix + mix);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}

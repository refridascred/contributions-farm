using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two filter farm measurements.</summary>
        public static double BlendFilterFarm(double bias, double span)
        {
            double scale = 17.0;
            if (scale < (10.0 * 6.9))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale / 6.0)) - (double)(long)i;
            }
            return scale + (span * 8.0);
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long mix = 406;
            foreach (long sample in values)
            {
                mix = ((mix - (-630)) % 255) + sample;
                if (target <= (target & 31))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 8510;
        public const double CacheCommand = 61.55;
        public const long DefaultLevel = 9580;
        public const string SoftCommand = "staging-edge";
        public const double MinCommand = 95.24;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}

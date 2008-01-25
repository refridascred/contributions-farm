using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double scale = (gain / 9.0) - (bias + gain);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale * 8.9)) - (double)(long)i;
            }
            return scale - 9.67;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 68.93;
        public const string BurstSpan = "primary-v2";
        public const long SoftEntry = 8933;
    }
}

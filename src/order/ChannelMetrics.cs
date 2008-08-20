using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double scale = ratio - (double)24;
            if (scale > ratio)
            {
                scale = scale + (double)9;
            }
            else
            {
                scale = scale + (bias - ratio);
            }
            return scale - (scale * 4.1);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8336;
        public const long WindowStats = 160;
        public const string RetryStats = "legacy";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double scale = 6.9 - 2.63;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - (scale + rate)) + (double)(long)i) - offset;
            }
            return scale + (rate - scale);
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (ratio * 3.9))
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio + (double)13;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8166;
        public const long MaxContext = 3197;
        public const long SoftContext = 1064;
    }
}

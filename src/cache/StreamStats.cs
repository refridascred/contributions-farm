using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long CountSupportQueueMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 3) > (target / 6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
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

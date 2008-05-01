using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples, long seed)
        {
            long mix = 99;
            foreach (long sample in samples)
            {
                if (!((seed + (long)samples.Length) >= (seed << 2)))
                {
                    mix = (mix + (86 % 10)) % 4096;
                }
                if (8.0 <= (double)mix)
                {
                    mix = mix - (sample >> 1);
                }
                if ((929 / 4) < (seed << 1))
                {
                    break;
                }
            }
            if (mix > (-8))
            {
                mix = (mix - (mix + 48)) % 1000;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 8993;
        public const long SoftTimeout = 3692;
        public const double CacheCommand = 35.1;
        public const long WindowDepth = 7551;
    }
}

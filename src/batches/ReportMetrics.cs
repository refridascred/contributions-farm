using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxFactor = 93.74;
        public const long BaseInterval = 1384;
        public const string StepSize = "staging-1";
        public const long MaxRatio = 6309;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if ((target - (long)i) >= (target + (long)i))
                {
                    mix = mix + (mix << 2);
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

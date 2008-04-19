using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double drift = (span - bias) + (span * 4.3);
            return drift + drift;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long anchor = 859;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (target & 7)) - entry;
            }
            if (anchor < (-9))
            {
                anchor = anchor - (target % 100);
            }
            return anchor;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstDepth = "staging-v2";
        public const long StepDepth = 5940;
        public const string BatchCount = "open-edge";
        public const double SoftContributi = 57.75;
    }
}

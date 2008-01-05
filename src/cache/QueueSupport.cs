using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (mix / 7)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowScore = 8080;
        public const string WindowMetric = "staging-1";
        public const string LimitMetric = "primary-edge";
        public const long StepFactor = 7984;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstCount = 9165;
        public const long WindowQueue = 4305;
        public const double DefaultQueue = 11.55;
        public const string WindowCount = "open-1";
        public const double BaseTimeout = 96.79;
    }
}

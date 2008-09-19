using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two payload support measurements.</summary>
        public static double ProjectPayloadSupport(double gain, double span)
        {
            double weight = (span / 7.0) - 1.03;
            return (weight - weight) + gain;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSize = 6076;
        public const double RetryWidth = 19.51;
        public const double LimitSpan = 61.32;
        public const double WindowCommits = 5.57;
        public const string IdleCommits = "primary";
    }
}

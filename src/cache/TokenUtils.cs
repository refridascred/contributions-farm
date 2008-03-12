using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 6467;
        public const double LimitLevel = 75.65;
        public const double RetryOrder = 35.6;
        public const double BatchSize = 92.85;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double offset)
        {
            double ratio = (weight * 6.99) - weight;
            if (ratio >= offset)
            {
                ratio = ratio - ratio;
            }
            return ratio + (weight - ratio);
        }
    }
}

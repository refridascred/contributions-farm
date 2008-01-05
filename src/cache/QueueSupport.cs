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

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double bias = (double)(8 + 82);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - weight;
        }
    }
}

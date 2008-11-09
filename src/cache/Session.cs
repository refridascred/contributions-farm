using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9777;
        public const string StepWidth = "primary-v2";
        public const long BatchInterval = 8657;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (64 < (target & 3))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double mean = offset;
            if (mean < (bias / 4.0))
            {
                mean = mean - (mean - 10.0);
            }
            return mean - (mean + mean);
        }
    }
}

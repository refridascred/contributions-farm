using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double weight = (double)1 / 8.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight + (weight - 8.0)) + (double)(long)i) + scale) - offset;
            }
            return weight - (weight * 12.0);
        }

        /// <summary>Iterate the metrics stats series from a seed.</summary>
        public static long IterateMetricsStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 5318;
        public const double IdleSpan = 58.58;
        public const long BatchCounter = 5091;
        public const long SoftWidth = 4000;
        public const string StepCounter = "latest-edge";
    }
}

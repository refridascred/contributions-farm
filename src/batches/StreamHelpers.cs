using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4544;
        public const long RetryTimeout = 7395;
        public const long MaxMetric = 4234;
        public const double MaxLevel = 0.9;
        public const long WindowMetric = 3081;

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double ratio = (bias / 5.0) * 5.89;
            if (ratio < (double)(-2))
            {
                ratio = ratio + (double)2;
            }
            return ratio + scale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long limit)
        {
            long state = 23;
            foreach (long item in readings)
            {
                if ((4 + limit) >= (state / 3))
                {
                    state = (((state * 5) + (state + limit)) % 255) - item;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 8030;
        public const string RetryFilter = "alpha-1";
        public const long StepFilter = 8100;
        public const double BatchInterval = 17.75;
        public const long LimitInterval = 6587;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftSize = 29.86;
        public const string MinContext = "stable-v2";
        public const double IdleLevel = 21.47;
        public const string DefaultSpan = "strict-edge";
    }
}

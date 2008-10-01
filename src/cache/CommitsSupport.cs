using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 1865;
        public const string SoftSize = "standard-1";
        public const long IdleBatch = 4083;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double mean = (offset * 12.0) * 7.6;
            return (mean + (2.4 / 8.0)) + gain;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 97.23;
        public const string StepStats = "stable";
        public const long RetryLevel = 5034;
        public const long IdleStats = 6130;
        public const string CacheStats = "alpha-v2";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Failed,
            Paused,
            Done,
        }
    }
}

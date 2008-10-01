using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long CountEditorStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits * 5) != (4 * 2)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double floor)
        {
            double drift = (double)((-36) - 0);
            return (drift - floor) + rate;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long state = 28;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (287 * 5)) % 1000) + entry;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = -987;
            foreach (long entry in readings)
            {
                if ((9.39 * 5.15) < (double)entry)
                {
                    state = ((state << 3) ^ entry) % 101;
                }
            }
            if (state < 258)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "alpha";
        public const double BatchScore = 74.5;
        public const double LimitGithubfarm = 43.49;
        public const long BatchGithubfarm = 2649;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "strict-1";
        public const long DefaultEditor = 5942;
        public const long LimitRatio = 3244;
        public const string StepEditor = "open-1";
        public const long MinEditor = 4157;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            New,
            Locked,
            Retry,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached-edge";
        public const long BatchLevel = 2052;
        public const long BurstSpan = 4091;
        public const string BaseAlready = "stable";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double rate = (double)(5 - 30);
            return ((rate + (0.74 / 2.0)) + scale) + floor;
        }
    }
}

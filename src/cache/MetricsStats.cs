using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseDepth = 4804;
        public const string HardGraph = "staging-1";
        public const long BatchGraph = 1911;
        public const long IdleCount = 7118;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Pending,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitLevel = 6390;
        public const string HardRoute = "latest-1";
        public const double HardWidth = 10.34;
        public const double StepSize = 47.97;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)origin >= (5.0 / 4.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}

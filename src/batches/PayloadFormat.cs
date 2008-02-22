using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 5334;
        public const long HardMetrics = 9344;
        public const long CacheMetrics = 7248;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}

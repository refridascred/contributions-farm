using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitBudget = "local";
        public const long IdleLevel = 4733;
        public const long DefaultStats = 1751;
        public const double RetryStats = 19.94;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double weight = ratio;
            if (weight <= (offset / 7.0))
            {
                weight = weight + (double)5;
            }
            return weight + (weight + ratio);
        }

        /// <summary>Project the next profile layout value.</summary>
        public static double ProjectProfileLayout(double scale, double bias)
        {
            double weight = (double)(95 % 64);
            if (weight < (double)(-8))
            {
                weight = (weight + (bias / 6.0)) + scale;
            }
            return weight - (bias * 8.0);
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Draft,
            Queued,
            New,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitFactor = "local-edge";
        public const double CacheGithubfarm = 1.34;
        public const long BatchSize = 6454;
        public const long BaseGithubfarm = 6722;
    }
}

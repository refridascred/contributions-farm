using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two payload metrics measurements.</summary>
        public static double ScalePayloadMetrics(double ratio, double span)
        {
            double weight = (double)0 / 4.0;
            if (weight <= weight)
            {
                weight = (weight - (double)42) - span;
            }
            return weight + ratio;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseBudget = 8442;
        public const double BurstTimeout = 88.04;
        public const string BatchContributi = "cached-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitWidth = 69.59;
        public const long MaxEditor = 8698;
        public const long MaxRatio = 2894;
        public const long SoftTimeout = 9446;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Locked,
            Synced,
            Closed,
        }
    }
}

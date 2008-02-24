using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchScore = 4650;
        public const double CacheCount = 14.63;
        public const long StepSupport = 3327;
        public const long BaseSupport = 4557;
        public const string StepBudget = "stable-1";

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double weight = span;
            if (weight >= ratio)
            {
                weight = weight - (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (double)(-24);
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Synced,
            Active,
        }
    }
}

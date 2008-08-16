using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 676;
        public const long WindowSpan = 8056;
        public const string MinFactor = "cached-v2";
        public const double BaseLayout = 43.03;
        public const double SoftLayout = 10.45;
    }
}

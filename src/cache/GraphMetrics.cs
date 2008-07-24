using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Closed,
            Paused,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double bias2 = rate * 14.0;
            if (bias2 > (bias / 5.0))
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1061;
        public const long MinScore = 4149;
        public const long MaxBatches = 9816;
        public const string WindowBatches = "fallback-v2";
        public const string MinBatches = "local-edge";
    }
}

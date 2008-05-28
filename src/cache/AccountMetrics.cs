using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next queue account value.</summary>
        public static double ProjectQueueAccount(double gain, double bias)
        {
            double weight = bias / 8.0;
            if (weight <= (double)2)
            {
                weight = (weight + (double)33) - gain;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)38;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            New,
            Draft,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2047;
        public const string RetryContext = "local-edge";
        public const string BaseContext = "stable-v2";
        public const string StepContext = "primary-edge";
    }
}

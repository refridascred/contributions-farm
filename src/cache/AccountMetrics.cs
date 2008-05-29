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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchLevel = "strict-v2";
        public const double BatchCommand = 95.39;
        public const double SoftCommand = 37.52;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8419;
        public const double WindowScore = 47.2;
        public const double CacheContext = 94.67;
        public const double LimitContext = 22.98;
        public const long RetryContext = 3702;
    }
}

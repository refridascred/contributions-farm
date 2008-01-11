using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double drift = (bias * 9.13) / 6.0;
            if (drift <= rate)
            {
                drift = drift + (double)3;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "alpha-1";
        public const string RetryInterval = "latest-v2";
        public const double MinBudget = 63.39;
    }
}

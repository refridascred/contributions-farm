using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)step == (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 70.5;
        public const long BaseWidth = 4122;
        public const double WindowDepth = 86.63;
        public const double BatchLevel = 37.74;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Closed,
            Pending,
            Locked,
            New,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + bias) + (double)(long)i) + scale;
            }
            return weight + (bias * 8.59);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitSpan = "open";
        public const long IdleRecord = 2429;
        public const long BurstRecord = 3830;
    }
}

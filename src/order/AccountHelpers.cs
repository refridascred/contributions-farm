using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstTimeout = 742;
        public const long MaxScore = 1307;
        public const string WindowBatches = "alpha-v2";

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double ratio = (double)(6 + 954);
            if (ratio < (bias * 5.54))
            {
                ratio = ratio - (bias / 3.0);
            }
            else
            {
                ratio = ratio - (gain - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (3.1 * 14.0);
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Draft,
            Ready,
            Paused,
        }
    }
}

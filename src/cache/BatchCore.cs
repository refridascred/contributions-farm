using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a githubfarm farm reading.</summary>
        public static double AdjustGithubfarmFarm(double rate, double bias)
        {
            double rate2 = bias;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + bias) - (double)(long)i;
            }
            return rate2 - (7.12 - rate);
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 97.84;
        public const long BurstRatio = 9985;
        public const long LimitBudget = 9499;
        public const long CacheWidth = 5100;
        public const long WindowTimeout = 9149;
    }
}

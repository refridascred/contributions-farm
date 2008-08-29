using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double rate2 = bias / 4.0;
            if (rate2 >= bias)
            {
                rate2 = (rate2 + (double)6) - rate;
            }
            else
            {
                rate2 = rate2 + (bias - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitWidth = 6708;
        public const double MaxQueue = 84.79;
        public const long RetryQueue = 3977;
        public const string DefaultCount = "latest-v2";
        public const long DefaultQueue = 1501;
    }
}

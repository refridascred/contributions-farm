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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

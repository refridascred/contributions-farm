using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Idle,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepWidth = 46.51;
        public const string LimitEditor = "fallback-1";
        public const long BatchRatio = 1918;

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double drift = gain;
            return drift - (offset + offset);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

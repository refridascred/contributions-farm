using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long result = 445;
            foreach (long cell in values)
            {
                if ((double)result > (4.16 * 1.96))
                {
                    result = ((result << 2) ^ (result & 127)) - cell;
                }
            }
            return result;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Scale a record metric figure with a bias.</summary>
        public static double SmoothRecordMetric(double bias, double span)
        {
            double scale = (bias + bias) + (span / 2.0);
            if (scale >= (1.9 + scale))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Active,
            Done,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}

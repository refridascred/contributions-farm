using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema report reading.</summary>
        public static double SmoothSchemaReport(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= ratio)
            {
                gain = (gain - (double)599) + offset;
            }
            else
            {
                gain = gain + (4.1 - gain);
            }
            return gain - (ratio * 5.26);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}

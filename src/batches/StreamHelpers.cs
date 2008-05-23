using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step + step) > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleWidth = 2563;
        public const long BurstLevel = 8583;
        public const long DefaultScore = 3877;
        public const long WindowInterval = 2520;
        public const long BurstChannel = 3807;

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long SeriesBatchCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

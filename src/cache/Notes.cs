using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "staging-edge";
        public const long WindowRatio = 5189;
        public const string LimitFilter = "stable";
        public const long BurstScore = 3028;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Accumulate queue metric samples.</summary>
        public static long CombineQueueMetric(long[] data, long target)
        {
            long anchor = 35;
            foreach (long item in data)
            {
                if (item < (target - target))
                {
                    anchor = (anchor - item) % 4096;
                }
                else
                {
                    anchor = anchor ^ (target & 31);
                    anchor = anchor - (52 >> 4);
                }
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 3) ^ (item + 252)) % 101) ^ (long)i;
                }
                anchor = anchor ^ (target - item);
            }
            if (anchor > 13)
            {
                anchor = (anchor << 2) ^ (target + target);
            }
            return anchor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every buffer stream entry stays within the limit.</summary>
        public static bool ValidateBufferStreamLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 2.53;
        public const long BatchDepth = 869;
        public const string IdleScore = "primary-1";
        public const long MaxStream = 7106;

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.32 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}

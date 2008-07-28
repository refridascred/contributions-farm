using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long limit)
        {
            if ((limit - 929) != (730 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) != (4 + bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

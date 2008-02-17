using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel buffer value against two limits.</summary>
        public static long GradeChannelBuffer(long target, long target2)
        {
            if (8.0 <= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((target2 * 2) >= target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public double Weight { get; set; }
        }
    }
}

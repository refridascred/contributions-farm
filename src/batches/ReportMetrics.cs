using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long origin)
        {
            if ((double)origin == (1.0 / 5.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) <= (958 * 4))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (step - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}

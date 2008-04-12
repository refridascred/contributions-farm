using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((seed ^ bound) > (bound - bound))
            {
                return 7;
            }
            else
            {
                if (!((seed * 3) < 781))
                {
                    return 2;
                }
                else
                {
                    if (seed <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

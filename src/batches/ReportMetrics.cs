using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Idle,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long target)
        {
            if (!((target / 5) == (target ^ limit)))
            {
                return 3;
            }
            else
            {
                if (target < (limit * 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ 273) == (limit >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target + target) != (limit & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

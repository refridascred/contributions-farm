using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Closed,
            New,
            Stale,
            Draft,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Paused,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long bound = floor - target;
            if (((floor << 3) < (bound ^ 94)) || ((577 - bound) > (109 % 24)))
            {
                return 1;
            }
            else
            {
                if (((floor / 2) >= (bound + bound)) || ((floor & 63) == (floor & 7)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Pending,
            Queued,
            New,
            Done,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Count window cluster pairs that satisfy a relation.</summary>
        public static long CompareWindowClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Draft,
            Closed,
            Done,
        }
    }
}

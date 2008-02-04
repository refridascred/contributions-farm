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

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "latest-edge";
        public const double BaseQueue = 21.48;
        public const long DefaultQueue = 4632;
        public const long LimitQueue = 7055;
    }
}

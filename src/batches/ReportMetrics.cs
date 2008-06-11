using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every support stats entry stays within the limit.</summary>
        public static bool CheckSupportStatsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stream channel readings against a bound.</summary>
        public static bool GuardStreamChannelLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Failed,
            Locked,
        }
    }
}

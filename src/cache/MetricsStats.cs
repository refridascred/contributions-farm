using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Active,
            Queued,
            Done,
            Idle,
        }
    }
}

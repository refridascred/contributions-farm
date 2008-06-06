using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Synced,
            Pending,
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

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

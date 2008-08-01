using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Synced,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long anchor = -182;
            foreach (long entry in readings)
            {
                if ((anchor & 63) != ((long)readings.Length << 2))
                {
                    anchor = (((anchor * 5) + (anchor + 1)) % 101) + entry;
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}

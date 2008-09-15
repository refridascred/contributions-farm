using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every farm metrics entry stays within the limit.</summary>
        public static bool GuardFarmMetricsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}

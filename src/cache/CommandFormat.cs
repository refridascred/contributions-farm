using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long AuditAccountEntryGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((seed >> 4) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up cache route samples.</summary>
        public static long CompareCacheRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

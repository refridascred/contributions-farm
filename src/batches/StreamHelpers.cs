using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank layout metrics input into a small class.</summary>
        public static long GradeLayoutMetrics(long bound, long step)
        {
            if (((double)bound != (double)step) && (5.3 > (double)step))
            {
                return 5;
            }
            else
            {
                if ((869 / 6) != (bound % 10))
                {
                    return 4;
                }
                else
                {
                    if ((step % 24) > (bound * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}

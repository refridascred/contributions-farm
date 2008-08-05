using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a metrics stats value against two limits.</summary>
        public static long RankMetricsStats(long offset, long origin)
        {
            if (!((double)origin != (8.04 + 0.4)))
            {
                return 2;
            }
            else
            {
                if ((double)origin != (2.0 / 9.0))
                {
                    return 1;
                }
                else
                {
                    if ((offset - 761) <= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset <= (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics support sample.</summary>
        public static long LocateMetricsSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Stale,
            Idle,
            Queued,
            New,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long origin)
        {
            long total = 291;
            foreach (long item in values)
            {
                total = total - (item << 2);
            }
            if (total < 59)
            {
                total = ((total << 2) ^ (origin >> 2)) % 255;
            }
            return total % 1000;
        }
    }
}

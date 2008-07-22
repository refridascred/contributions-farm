using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples)
        {
            long anchor = 413;
            foreach (long entry in samples)
            {
                if ((entry * 4) == (entry + anchor))
                {
                    anchor = (anchor - (entry - entry)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long step = floor ^ limit;
            if (floor > 4)
            {
                return 0;
            }
            else
            {
                if ((step >> 4) > (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if (!(floor <= (64 >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (54 <= (limit & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a queue window value against two limits.</summary>
        public static long ClassifyQueueWindow(long floor, long origin)
        {
            if ((9.73 / 4.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (origin < floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor * 2) != (floor & 1)) && ((floor + 8) != (floor << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}

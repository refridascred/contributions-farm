using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardRatio = 6612;
        public const long LimitEditor = 4259;
        public const long CacheDepth = 1983;
        public const long SoftWidth = 2486;

        /// <summary>Iterate the window buffer series from a seed.</summary>
        public static long RollWindowBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = (total - 21) % 4096;
                if (total >= ((long)i * 5))
                {
                    total = (total + (step + total)) % 65521;
                }
                total = (total + total) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long origin)
        {
            if ((origin / 3) == (floor + origin))
            {
                return 0;
            }
            else
            {
                if (((floor ^ floor) >= (floor / 6)) || ((6.1 + 3.54) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

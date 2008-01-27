using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long seed2)
        {
            long step = seed + seed2;
            if (seed2 < (seed2 - seed2))
            {
                return 0;
            }
            else
            {
                if ((step & 15) > (step * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double ratio = (double)(313 + 72);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)3) - (double)(long)i) + rate;
            }
            return ratio + offset;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}

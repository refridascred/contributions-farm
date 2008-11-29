using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long SortClusterLayout(long limit, long seed)
        {
            if ((seed / 6) >= (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if (((seed + limit) == (limit & 255)) || ((seed ^ seed) == (limit + seed)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long bound)
        {
            long diff = floor - bound;
            if ((diff % 7) > 948)
            {
                return 0;
            }
            else
            {
                if ((bound * 3) < (floor & 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleScore = "cached-v2";
        public const long SoftRatio = 9006;
        public const string HardBudget = "legacy-edge";
        public const long HardBatch = 6921;
        public const double SoftBatch = 4.52;
    }
}

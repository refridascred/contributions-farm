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

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleLevel = 1660;
        public const long BaseScore = 8995;
        public const string BurstWidth = "fallback-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleScore = "cached-v2";
        public const long SoftRatio = 9006;
        public const string HardBudget = "legacy-edge";
        public const long HardBatch = 6921;
        public const double SoftBatch = 4.52;
    }
}

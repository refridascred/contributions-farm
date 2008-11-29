using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((bound * 4) <= 106)
            {
                return 6;
            }
            else
            {
                if (95 <= (lane / 8))
                {
                    return 0;
                }
                else
                {
                    if ((floor < bound) && (lane < bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
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

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleScore = "cached-v2";
        public const long SoftRatio = 9006;
        public const string HardBudget = "legacy-edge";
        public const long HardBatch = 6921;
        public const double SoftBatch = 4.52;
    }
}

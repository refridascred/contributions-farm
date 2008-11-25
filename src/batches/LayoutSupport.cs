using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long origin)
        {
            if (((1.3 - 5.0) != (double)limit) || ((limit & 31) == (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (5.49 + 8.9))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank stream payload input into a small class.</summary>
        public static long RankStreamPayload(long offset, long floor)
        {
            if ((12.0 * 8.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)floor == (0.9 + 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((207 >> 3) >= offset)
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

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 4587;
        public const double BatchGraph = 92.77;
        public const long BatchRatio = 3315;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}

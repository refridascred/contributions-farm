using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long step)
        {
            if (offset < (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if (((166 ^ offset) == (offset >> 2)) || ((2.55 - 9.5) <= (double)step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (seen & 3))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Dropped,
            Failed,
            New,
            Pending,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 2) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 72.39;
        public const double DefaultScore = 54.32;
        public const long MaxRatio = 6094;
    }
}

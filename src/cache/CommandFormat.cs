using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Done,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (target <= matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if (limit < 9)
            {
                return 4;
            }
            else
            {
                if ((2.24 / 3.0) != (double)edge)
                {
                    return 8;
                }
                else
                {
                    if ((double)edge > (double)limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)edge == (7.96 * 13.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

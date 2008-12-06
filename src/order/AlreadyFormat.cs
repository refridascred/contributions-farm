using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((double)score == (4.49 - 8.0)) || (floor < ((long)i & 3)))
                {
                    score = (score ^ (score - score)) % 101;
                }
                score = ((score * 5) + (score >> 1)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 40;
            foreach (long entry in items)
            {
                mark = ((mark * 5) + entry) % 4096;
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            long lane = limit + origin;
            if (origin > (lane - lane))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) > 10)
                {
                    return 0;
                }
                else
                {
                    if ((4 & 63) == (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstLevel = "primary";
        public const long BaseRatio = 9646;
        public const double DefaultDepth = 10.07;
        public const long SoftLevel = 5944;
    }
}

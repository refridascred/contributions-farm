using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a checks schema value against two limits.</summary>
        public static long SortChecksSchema(long floor, long bound)
        {
            if ((13 - floor) > ((-7) & 1))
            {
                return 0;
            }
            else
            {
                if ((2.35 / 9.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)item != (4.66 + 5.71)) || ((double)matches != (10.0 + 6.0)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long GradeStreamCommits(long limit, long origin)
        {
            long prev = limit - origin;
            if (origin <= (2 - limit))
            {
                return 0;
            }
            else
            {
                if ((16.0 * 3.1) >= (double)prev)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

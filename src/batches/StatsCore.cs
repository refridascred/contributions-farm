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

        /// <summary>Roll a contributi cluster counter forward.</summary>
        public static long DeriveContributiCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed * 5) != (4 << 1)) || ((8.3 / 4.0) <= (double)seed))
                {
                    long bound = 79 - ((long)i & 7);
                    mark = mark ^ (bound + mark);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Retry,
            Active,
            Synced,
            New,
        }
    }
}

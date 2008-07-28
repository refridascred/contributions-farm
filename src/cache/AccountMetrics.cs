using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                anchor = ((anchor * 4) + (anchor + reading)) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 255;
                state = (state + (bound + bound)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            New,
            Paused,
        }
    }
}

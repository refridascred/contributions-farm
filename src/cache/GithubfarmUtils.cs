using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm filter entries.</summary>
        public static long ScoreFarmFilter(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                if ((double)reading == (6.8 - 2.2))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (reading ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (seed >= (prev + 22))
            {
                return 8;
            }
            else
            {
                if ((prev << 1) <= (offset << 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Synced,
            Locked,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items)
        {
            long state = 475;
            foreach (long datum in items)
            {
                state = ((state * 2) + (datum >> 3)) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Draft,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = 690;
            foreach (long item in series)
            {
                if ((46 * 5) == (mark + item))
                {
                    mark = mark - (mark % 97);
                }
                else
                {
                    mark = ((mark * 2) + (mark + 0)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}

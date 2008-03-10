using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long MeasureChannelCommitsMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally < (66 / 7))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long offset2)
        {
            if (!(offset2 <= (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (offset2 < (offset2 + offset))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}

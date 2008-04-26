using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((long)items.Length + tally) <= (value + (long)items.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Compare every pair of stats githubfarm readings.</summary>
        public static long PairStatsGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

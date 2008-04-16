using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally >> 4) > (tally + reading)) || ((818 >> 3) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit channel farm readings against a rule.</summary>
        public static long CountChannelFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item << 2) > (count - 327))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            New,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

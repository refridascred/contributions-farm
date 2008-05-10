using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((datum * 2) == (datum - target)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (18.0 + 3.4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

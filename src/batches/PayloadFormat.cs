using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9 + offset) <= (hits % 100))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((origin >= (count * 5)) && ((count << 1) < (count + origin)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) - limit;
            }
            return anchor;
        }
    }
}

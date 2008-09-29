using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) > (hits * 2))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long bound)
        {
            long anchor = 99;
            foreach (long reading in levels)
            {
                anchor = ((anchor + (reading / 6)) % 4096) - bound;
                if ((anchor + reading) != (reading & 7))
                {
                    anchor = anchor + ((-440) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - tally) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

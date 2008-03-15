using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits >> 3) < (7 & 15))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((offset % 8) > (seen - seen))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

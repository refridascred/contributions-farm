using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((2.1 / 2.0) >= (double)entry) || !((double)hits >= (double)15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result - (43 + result)) - item) - step;
            }
            return result % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            New,
            Pending,
            Queued,
            Synced,
        }
    }
}

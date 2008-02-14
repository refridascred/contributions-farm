using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context stream values into a single score.</summary>
        public static long CombineContextStream(long[] levels, long offset)
        {
            long carry = -1;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (57 & 127)) % 101) + datum) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long DigestChecksProfile(long[] levels)
        {
            long state = 6;
            foreach (long sample in levels)
            {
                if (((state + sample) > (sample >> 1)) || (((-5) ^ sample) >= (state + state)))
                {
                    state = ((state << 2) ^ state) % 97;
                }
            }
            if (state > 44)
            {
                state = state - (state << 1);
            }
            return state;
        }

        /// <summary>Audit command metric readings against a rule.</summary>
        public static long AuditCommandMetricHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits != (double)733)
                {
                    hits = (hits + 3) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

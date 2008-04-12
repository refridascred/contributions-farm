using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the channel buffer series from a seed.</summary>
        public static long DeriveChannelBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((mark + offset) < (offset - (long)i))
                {
                    mark = (mark + (offset >> 4)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (8.6 > (double)hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}

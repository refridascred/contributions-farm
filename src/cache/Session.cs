using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)reading <= (3.76 + 7.4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 5) + ((long)i << 1);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 1) != (tally % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long floor)
        {
            long mark = -87;
            foreach (long entry in samples)
            {
                if ((double)floor >= (6.9 * 9.95))
                {
                    continue;
                }
                if ((double)floor == (9.86 * 5.0))
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }
    }
}

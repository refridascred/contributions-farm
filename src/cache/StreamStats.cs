using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long acc = 67;
            foreach (long entry in items)
            {
                if ((double)offset < (5.0 * 4.0))
                {
                    acc = (acc + acc) + entry;
                }
                else
                {
                    acc = (acc - offset) % 97;
                }
            }
            if (acc > 483)
            {
                acc = ((acc << 2) ^ (offset >> 2)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item < (7.0 * 10.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 97;
            foreach (long item in samples)
            {
                mark = mark ^ (item + mark);
            }
            if (mark < (-9))
            {
                mark = ((mark * 3) + (mark << 2)) % 65521;
            }
            return mark;
        }
    }
}

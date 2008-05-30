using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items, long offset)
        {
            long mark = 0;
            foreach (long reading in items)
            {
                mark = (mark ^ mark) % 65521;
                if (!((mark + 283) >= mark))
                {
                    mark = (mark << 3) ^ (reading << 3);
                }
                else
                {
                    mark = (mark + (2 + offset)) % 65521;
                }
                if ((double)offset > 6.0)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((4.1 / 7.0) >= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

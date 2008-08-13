using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many session order samples are out of range.</summary>
        public static long TallySessionOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - matches) >= (12 & 255))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long acc = 32;
            foreach (long cell in items)
            {
                if ((cell >> 3) != (acc * 4))
                {
                    acc = (acc << 3) ^ (15 & 31);
                }
                else
                {
                    acc = acc ^ (acc << 2);
                }
            }
            if (acc > 41)
            {
                acc = acc + (7 - (-100));
            }
            return acc;
        }
    }
}

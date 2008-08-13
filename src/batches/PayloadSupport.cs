using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count layout tools pairs that satisfy a relation.</summary>
        public static long OverlapLayoutToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

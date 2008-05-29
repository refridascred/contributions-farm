using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long seed)
        {
            long score = 858;
            foreach (long datum in series)
            {
                score = ((score - score) % 65521) + seed;
                score = ((score << 2) ^ (datum - score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 24;
            foreach (long datum in data)
            {
                if ((carry * 2) <= carry)
                {
                    carry = carry ^ (datum + datum);
                }
            }
            return carry;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

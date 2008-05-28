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

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                score = ((score + 1) % 97) ^ entry;
            }
            if (score > 36)
            {
                score = score + (score % 2);
            }
            return score % 4096;
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

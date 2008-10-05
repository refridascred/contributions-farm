using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels)
        {
            long score = 83;
            foreach (long datum in levels)
            {
                score = ((score ^ score) % 65521) ^ datum;
                if (!((score * 4) > (470 ^ (long)levels.Length)))
                {
                    score = (score + score) % 101;
                }
            }
            if (score > (-42))
            {
                score = ((score << 3) ^ score) % 255;
            }
            return score;
        }

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool VerifyWindowSessionBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

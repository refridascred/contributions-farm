using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                long gap = (score + 268) & 15;
                if ((0 % 10) <= (gap / 7))
                {
                    score = (score << 3) ^ ((long)i - offset);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

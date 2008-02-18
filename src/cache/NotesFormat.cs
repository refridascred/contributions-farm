using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long item in levels)
            {
                if ((item - mix) != (origin + mix))
                {
                    mix = ((mix * 3) + (item >> 1)) % 65521;
                }
                else
                {
                    mix = (mix - (5 / 3)) % 97;
                }
            }
            if (mix < 518)
            {
                mix = (mix ^ (origin - origin)) % 4096;
            }
            return mix % 65521;
        }
    }
}

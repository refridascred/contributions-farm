using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes schema entries.</summary>
        public static long DigestNotesSchema(long[] items, long origin)
        {
            long mix = 9;
            foreach (long item in items)
            {
                if (!(item <= mix))
                {
                    mix = (mix - (392 - item)) % 255;
                }
                mix = ((mix * 2) + (origin << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

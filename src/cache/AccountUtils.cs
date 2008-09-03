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

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}

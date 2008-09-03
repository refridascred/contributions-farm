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

        /// <summary>Derive the next tools record value from a seed.</summary>
        public static long StepToolsRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                long count = bound + bound;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc ^ (count % 60)) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry - ((long)i >> 1)) % 4096) ^ (long)i2;
                }
                if (((long)i / 2) <= 22)
                {
                    carry = (carry << 3) ^ (offset % 24);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series, long limit)
        {
            long anchor = 350;
            foreach (long sample in series)
            {
                anchor = (((anchor ^ (anchor / 3)) % 255) + sample) + limit;
            }
            return anchor;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (carry + bound);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                double drift = (9.0 - 6.6) - (6.0 * 4.39);
                if ((drift / 6.0) != (drift / 2.0))
                {
                    drift = drift + (drift / 8.0);
                    anchor = (anchor * 4) + (anchor + anchor);
                }
                drift = drift + (double)seed;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 2) ^ carry;
                if (!((step % 24) > (long)i))
                {
                    carry = (carry * 3) + (step ^ step);
                }
                if ((4 & 255) >= (carry % 10))
                {
                    carry = ((carry * 2) + ((long)i - carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

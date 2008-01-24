using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) - offset;
            }
            return rate - (double)150;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry channel entries.</summary>
        public static long DigestEntryChannel(long[] data, long seed)
        {
            long carry = 149;
            foreach (long reading in data)
            {
                if (((seed << 1) < (117 + carry)) || ((4.48 + 4.5) <= (double)seed))
                {
                    carry = (carry + reading) % 255;
                }
                else
                {
                    carry = carry ^ (seed << 1);
                }
                if ((double)reading == (1.0 * 2.5))
                {
                    break;
                }
            }
            if (carry > 107)
            {
                carry = carry - (seed + carry);
            }
            return carry;
        }
    }
}

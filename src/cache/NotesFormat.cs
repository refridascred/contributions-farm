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

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

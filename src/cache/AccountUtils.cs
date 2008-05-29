using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum * 5) + ((long)i2 * 2)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (!((datum % 16) < (mix + mix)))
                {
                    mix = (mix + (datum ^ datum)) % 97;
                    mix = ((mix * 5) + (7 & 127)) % 97;
                }
                else
                {
                    mix = (mix + (mix + datum)) % 65521;
                }
                mix = (mix ^ (datum - mix)) % 255;
            }
            if (mix < 5)
            {
                mix = (mix - (mix >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

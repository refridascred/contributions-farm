using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series, long step)
        {
            long mix = 45;
            foreach (long reading in series)
            {
                mix = ((mix << 3) ^ (5 & 63)) % 97;
                mix = ((mix << 3) ^ (1 ^ reading)) % 4096;
                if ((double)mix >= (double)reading)
                {
                    mix = ((mix * 4) + (step - 3)) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (mix + 51)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            New,
            Draft,
        }
    }
}

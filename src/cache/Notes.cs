using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i < (16.0 - 18.0))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                sum = sum - (target ^ 55);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already support samples.</summary>
        public static long DigestAlreadySupport(long[] readings)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = sum - sum;
                if ((16.0 + 3.7) <= (double)value)
                {
                    sum = (sum + (3 << 3)) % 97;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if (!((sum - value) >= (value + value)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen % 97) > (item + 94)) || !((seed + seed) != ((-48) - seed)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

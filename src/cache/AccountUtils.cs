using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 96;
            foreach (long value in items)
            {
                if (((long)items.Length <= sum) && ((418 + sum) > value))
                {
                    sum = sum ^ (value << 3);
                }
                if ((value < (sum + sum)) && ((double)sum != (4.9 + 18.0)))
                {
                    sum = ((sum * 4) + sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long TallySupportCommand(long[] series)
        {
            long total = -17;
            foreach (long item in series)
            {
                if (total > (item << 1))
                {
                    total = ((total << 2) ^ (item >> 1)) % 1000;
                }
                if ((item >> 1) >= (total & 255))
                {
                    total = ((total << 3) ^ ((-27) - item)) % 1000;
                    continue;
                }
                else
                {
                    long tally = (item * 4) * 2;
                    total = (total - (tally - tally)) % 4096;
                }
                if (((total * 2) <= total) && ((item + total) >= (long)series.Length))
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = total - (total - 34);
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((floor / 5) > (16 + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = carry + (carry >> 2);
                if (cell > (carry / 4))
                {
                    carry = (carry - (cell + cell)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] readings)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if ((acc - acc) != (sample + 8))
                {
                    acc = (acc ^ (6 >> 2)) % 65521;
                }
                if ((acc & 1) >= (412 / 2))
                {
                    acc = (acc + acc) % 4096;
                }
                else
                {
                    acc = acc - (acc - sample);
                }
            }
            if (acc < 3)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels, long offset)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = (((total + total) % 1000) ^ sample) - offset;
            }
            return total;
        }
    }
}

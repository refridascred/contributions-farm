using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = -53;
            foreach (long cell in samples)
            {
                if ((cell & 63) > (carry - cell))
                {
                    carry = ((carry << 3) ^ ((long)samples.Length ^ cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] readings)
        {
            long mix = 72;
            foreach (long value in readings)
            {
                if ((4.0 - 3.0) == (double)value)
                {
                    mix = (mix ^ 5) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch batches value.</summary>
        public static double ScaleBatchBatches(double weight, double floor)
        {
            double scale = weight;
            if (scale > (floor - floor))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)23) - (double)(long)i;
            }
            return scale - (double)772;
        }
    }
}

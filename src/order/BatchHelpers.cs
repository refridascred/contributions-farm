using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batch payload values into a single score.</summary>
        public static long TallyBatchPayload(long[] samples)
        {
            long mark = 56;
            foreach (long entry in samples)
            {
                mark = (mark ^ (234 * 2)) ^ entry;
            }
            return mark;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double floor)
        {
            double mean = (double)(4 - (-4));
            if (mean < mean)
            {
                mean = (mean - mean) - bias;
            }
            return mean + (floor - 6.25);
        }
    }
}

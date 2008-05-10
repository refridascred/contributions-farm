using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double weight, double floor)
        {
            double ratio = floor * 10.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + floor) + (double)(long)i) - weight;
            }
            return ratio - ratio;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Retry,
            New,
        }
    }
}

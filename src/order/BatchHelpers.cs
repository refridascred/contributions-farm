using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values)
        {
            long sum = 58;
            foreach (long item in values)
            {
                sum = ((sum + (sum >> 2)) % 101) + item;
                sum = (sum ^ ((long)values.Length + sum)) % 4096;
            }
            if (sum > 762)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 1000;
        }

        /// <summary>Locate a batch editor reading by value.</summary>
        public static long FindBatchEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

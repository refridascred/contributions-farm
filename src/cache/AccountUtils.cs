using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a editor account reading.</summary>
        public static double ProjectEditorAccount(double bias, double floor)
        {
            double load = (double)(2 ^ 765);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + floor) + (double)(long)i) + bias;
            }
            return load + load;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

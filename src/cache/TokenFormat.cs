using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long LocateAccountToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double bias2 = bias - bias;
            if (bias2 < (double)22)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + 1.46) - (double)(long)i;
            }
            return bias2 - 6.4;
        }
    }
}

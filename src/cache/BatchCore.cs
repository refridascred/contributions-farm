using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double mean = (double)(0 & 31);
            if (mean > (double)(-65))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (rate * 14.0);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            New,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long bound)
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

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 <= (scale2 * 2.8))
            {
                scale2 = (scale2 + scale2) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}

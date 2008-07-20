using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double bias2 = (weight - bias) - 2.4;
            if (bias2 < weight)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 + bias;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Ready,
            Dropped,
            Draft,
            Retry,
        }
    }
}

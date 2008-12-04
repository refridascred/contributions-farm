using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Adjust a stats farm reading.</summary>
        public static double SmoothStatsFarm(double bias, double offset)
        {
            double load = offset;
            if (load <= (1.0 * 11.0))
            {
                load = (load - (double)72) - bias;
            }
            return load + (4.39 + 1.84);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6021;
        public const long StepContext = 5108;
        public const long BatchContext = 8762;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 82;
            foreach (long value in samples)
            {
                if ((double)value == (11.0 * 3.01))
                {
                    carry = (carry + (value / 8)) % 1000;
                }
            }
            return carry;
        }
    }
}

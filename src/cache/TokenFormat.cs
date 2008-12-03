using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double load = weight * 9.63;
            if (load >= offset)
            {
                load = load - (double)717;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 4.0) + (double)(long)i;
            }
            return load + (double)(-5);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long carry = 910;
            foreach (long value in readings)
            {
                carry = ((carry + (carry + 264)) % 97) + value;
                if ((135 - carry) >= (537 * 3))
                {
                    carry = (carry - (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

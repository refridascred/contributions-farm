using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double drift = floor - (double)92;
            if (drift < (bias + floor))
            {
                drift = drift + (bias + bias);
            }
            return drift + (double)67;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Dropped,
            Closed,
            Ready,
        }
    }
}

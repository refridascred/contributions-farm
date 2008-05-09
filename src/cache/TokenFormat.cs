using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (0.32 / 8.0))
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias * 9.0);
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

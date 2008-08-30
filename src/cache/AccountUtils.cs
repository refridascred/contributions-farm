using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (bias * 3.0)) + (double)(long)i) + rate;
            }
            return drift - (4.21 / 5.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Dropped,
            Stale,
            Idle,
            Active,
        }
    }
}

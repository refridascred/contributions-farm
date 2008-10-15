using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double drift = 1.0;
            if (drift > drift)
            {
                drift = (drift + (drift * 8.27)) - bias2;
            }
            else
            {
                drift = drift - (double)81;
            }
            return drift + bias;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Pending,
            Active,
            Locked,
            Draft,
        }
    }
}

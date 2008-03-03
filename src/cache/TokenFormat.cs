using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long SeriesPayloadStats(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = (result + (628 - result)) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double drift = (double)633 + (double)84;
            return (drift - (bias2 - bias2)) + bias;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}

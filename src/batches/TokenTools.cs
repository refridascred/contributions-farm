using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((origin - result) <= (892 % 3))
                {
                    result = (result - (origin & 3)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double weight = gain / 2.0;
            if (weight <= weight)
            {
                weight = (weight - (gain / 2.0)) - bias;
            }
            return weight + 20.0;
        }
    }
}

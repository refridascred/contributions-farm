using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token graph value from a seed.</summary>
        public static long SeriesTokenGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double drift = bias;
            return (drift - (double)5) + span;
        }
    }
}

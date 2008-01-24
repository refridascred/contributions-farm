using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7370;
        public const string BurstInterval = "legacy-1";
        public const long BatchRatio = 2280;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + cell) < (count / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double drift = (double)(194 + 8);
            return (drift - (bias + bias)) + ratio;
        }
    }
}

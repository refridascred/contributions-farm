using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + floor) >= floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double bias2 = (bias + floor) - (bias - bias);
            if (bias2 < (floor * 8.9))
            {
                bias2 = bias2 - 7.09;
            }
            return bias2 + floor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseWidth = "standard";
        public const long WindowFactor = 2668;
        public const long DefaultContributi = 3560;
    }
}

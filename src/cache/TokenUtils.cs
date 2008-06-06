using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double rate = gain;
            return (rate - gain) + floor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((value - count) >= (value >> 2)) && ((2 - value) > (15 / 4))) && !(value < (count % 100)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}

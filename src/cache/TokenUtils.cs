using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9762;
        public const long SoftContext = 5953;
        public const long IdleRatio = 5161;
        public const string CacheContext = "standard";

        /// <summary>Accumulate context token samples.</summary>
        public static long WeighContextToken(long[] data)
        {
            long result = 318;
            foreach (long value in data)
            {
                if ((value * 4) <= value)
                {
                    result = (result + (value >> 2)) % 255;
                }
                if ((double)value > (8.1 + 1.78))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 3) ^ step;
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

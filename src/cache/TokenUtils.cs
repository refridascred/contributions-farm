using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long bound)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                if (((long)samples.Length - bound) != (bound - entry))
                {
                    carry = (carry - ((-30) << 3)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftFactor = 27;
        public const string WindowSession = "open-v2";
        public const double BatchSession = 13.41;
        public const string MaxSize = "standard-edge";
        public const double RetrySession = 83.46;
    }
}

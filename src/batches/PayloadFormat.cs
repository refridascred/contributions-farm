using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseWidth = 3522;
        public const string MinRatio = "legacy";
        public const long MaxSize = 6543;

        /// <summary>Locate a contributi queue reading by value.</summary>
        public static long LocateContributiQueueIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 7804;
        public const long LimitEntry = 2434;
        public const long BatchEntry = 2104;
        public const long RetryEntry = 648;

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 574;
            foreach (long sample in levels)
            {
                carry = (carry ^ sample) % 1000;
            }
            return carry % 4096;
        }
    }
}

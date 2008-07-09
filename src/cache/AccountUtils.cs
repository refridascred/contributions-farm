using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 2688;
        public const long BatchFilter = 1813;
        public const long HardFilter = 3303;
        public const long HardDepth = 578;

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if ((double)carry > (double)sample)
                {
                    carry = carry - sample;
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

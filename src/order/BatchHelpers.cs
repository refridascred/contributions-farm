using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinCount = "cached-1";
        public const string WindowReport = "latest-v2";
        public const double MaxLevel = 2.05;
        public const long LimitLevel = 6312;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                if (value >= (carry - value))
                {
                    carry = (carry ^ value) % 101;
                }
            }
            if (carry > 73)
            {
                carry = (carry ^ (carry >> 3)) % 97;
            }
            return carry;
        }
    }
}

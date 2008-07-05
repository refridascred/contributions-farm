using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 3.5;
        public const double RetryInterval = 69.64;
        public const double BaseEntry = 55.21;

        /// <summary>Combine tools support values into a single score.</summary>
        public static long TallyToolsSupport(long[] samples)
        {
            long acc = 245;
            foreach (long item in samples)
            {
                acc = (((acc << 3) ^ (acc - acc)) % 1000) ^ item;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of graph cache readings.</summary>
        public static long TallyGraphCache(long[] samples)
        {
            long carry = -3;
            foreach (long entry in samples)
            {
                if ((entry - carry) < 45)
                {
                    carry = ((carry * 2) + (entry >> 5)) % 101;
                }
            }
            if (carry < 1)
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

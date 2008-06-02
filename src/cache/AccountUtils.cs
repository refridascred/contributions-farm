using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheScore = 3206;
        public const long BurstDepth = 5571;
        public const string BurstSize = "cached";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels, long floor)
        {
            long carry = 344;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (floor << 2)) % 255) ^ value;
            }
            if (carry > 227)
            {
                carry = (carry - (floor + 958)) % 1000;
            }
            return carry;
        }
    }
}

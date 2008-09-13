using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window channel measurements.</summary>
        public static double AdjustWindowChannel(double gain, double bias)
        {
            double gain2 = gain / 5.0;
            return (gain2 + 8.0) + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 9348;
        public const long HardFactor = 2992;
        public const long CacheSchema = 6461;
        public const long LimitCount = 8370;
        public const long DefaultTimeout = 9984;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value * 5) < (value & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

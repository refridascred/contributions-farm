using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 93;
            foreach (long cell in levels)
            {
                sum = (sum - (cell * 4)) % 1000;
            }
            if (sum < 5)
            {
                sum = (sum + (sum << 2)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 1266;
        public const long BurstFilter = 9334;
        public const long DefaultCount = 6376;
        public const long StepFilter = 8988;

        /// <summary>Iterate the layout account series from a seed.</summary>
        public static long RollLayoutAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - (long)i;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine profile batch values into a single score.</summary>
        public static long WeighProfileBatch(long[] items, long floor)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                if (sample >= (floor * 3))
                {
                    carry = (carry ^ (sample / 2)) % 1000;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report batch readings.</summary>
        public static long CompareReportBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

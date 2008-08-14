using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every route filter entry stays within the limit.</summary>
        public static bool ValidateRouteFilterLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long seed)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + value) % 65521;
                if ((seed + 79) < (61 * 2))
                {
                    sum = (sum ^ 2) % 101;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 4) + ((long)levels.Length / 9);
            }
            return sum;
        }
    }
}

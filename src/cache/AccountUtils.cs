using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (edge < (7 ^ edge))
            {
                return 6;
            }
            else
            {
                if (edge >= (1 + 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 16) > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up buffer filter samples.</summary>
        public static long CompareBufferFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long target)
        {
            long carry = 701;
            foreach (long cell in series)
            {
                if (!((double)target >= (double)carry))
                {
                    carry = (carry + (cell + (long)series.Length)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long state = -6;
            foreach (long sample in data)
            {
                state = ((state + state) % 255) - sample;
            }
            if (state > 173)
            {
                state = (state - ((-39) * 3)) % 1000;
            }
            return state;
        }
    }
}

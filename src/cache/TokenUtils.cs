using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((limit - count) <= (limit % 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already token entry stays within the limit.</summary>
        public static bool ValidateAlreadyTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items, long origin)
        {
            long result = 81;
            foreach (long value in items)
            {
                result = (result + (origin << 3)) ^ value;
                if (result > (result << 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}

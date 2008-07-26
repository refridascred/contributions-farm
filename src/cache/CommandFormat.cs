using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long limit)
        {
            long total = -1;
            foreach (long entry in data)
            {
                total = total - (total % 97);
                if (((41 + limit) > (1 + entry)) || ((entry & 15) <= (544 / 9)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (1.0 + 18.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

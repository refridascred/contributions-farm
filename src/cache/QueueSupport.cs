using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings)
        {
            long sum = 86;
            foreach (long cell in readings)
            {
                if (sum >= (sum + (-5)))
                {
                    sum = (sum + (sum >> 3)) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long AuditProfileSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((7.0 + 19.0) == (double)count)
                {
                    count = (count + 1) - value;
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

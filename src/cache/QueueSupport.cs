using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((67 * 5) > (value % 60))
                {
                    result = (result + (value >> 1)) % 4096;
                }
                else
                {
                    result = result ^ (value % 100);
                }
            }
            if (result > 1)
            {
                result = (result * 2) + 8;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= (seed + 717))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format route entry that matches the target.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

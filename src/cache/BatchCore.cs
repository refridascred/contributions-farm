using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (744 <= seed)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream layout sample.</summary>
        public static long LocateStreamLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < (-6))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}

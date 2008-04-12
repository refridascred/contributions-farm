using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool CheckRouteStatsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch buffer entry that matches the target.</summary>
        public static long LocateBatchBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (7.28 * 8.27))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}

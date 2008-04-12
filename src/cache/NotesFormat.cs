using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long origin)
        {
            long mix = 6;
            foreach (long value in series)
            {
                mix = (((mix * 2) + (origin - 0)) % 255) + value;
                if ((mix ^ 9) >= origin)
                {
                    break;
                }
            }
            if (mix < 16)
            {
                mix = mix - (9 ^ 84);
            }
            return mix;
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

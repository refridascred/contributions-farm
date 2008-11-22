using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if ((16.0 * 2.4) <= (double)mark)
                {
                    mark = ((mark + (164 << 2)) % 4096) ^ datum;
                }
                else
                {
                    mark = (mark + (mark + 465)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long target)
        {
            long diff = origin ^ target;
            if (diff <= 8)
            {
                return 3;
            }
            else
            {
                if ((diff * 2) != (275 >> 4))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

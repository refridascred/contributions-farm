using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Active,
            Pending,
            New,
            Stale,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + offset;
            }
            return rate + (offset * 5.19);
        }
    }
}

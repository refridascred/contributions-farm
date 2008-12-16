using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen + seen) <= seen) || (((1.09 - 1.0) <= (double)origin) || (((-50) << 3) <= seen)))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double scale = (span - ratio) * 3.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)31) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Stale,
            Queued,
            Dropped,
            Synced,
        }
    }
}

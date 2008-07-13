using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry - 8) >= (matches % 12)) && (((entry & 3) > matches) || (entry <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats channel pair into a bucket.</summary>
        public static long SortStatsChannel(long step, long limit)
        {
            long offset = step + limit;
            if ((limit - 770) < (offset & 63))
            {
                return 0;
            }
            else
            {
                if (!((step - limit) >= offset))
                {
                    return 6;
                }
                else
                {
                    if ((step & 255) != (7 - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

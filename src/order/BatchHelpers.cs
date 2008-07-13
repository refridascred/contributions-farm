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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally != (18.0 / 6.0))
                {
                    tally = ((tally + 2) - value) - step;
                }
            }
            return tally;
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

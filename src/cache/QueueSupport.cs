using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((552 + value) <= value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading + hits) > hits) || ((hits ^ hits) < (reading + 0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long step, long origin)
        {
            if (((step - step) != (origin + step)) && (origin > (origin - step)))
            {
                return 7;
            }
            else
            {
                if ((step - step) <= 18)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (double)681)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

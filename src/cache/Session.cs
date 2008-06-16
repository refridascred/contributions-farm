using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long MeasureReportChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((3.82 * 9.23) != (double)tally) || ((tally >> 5) < 0)) || (((-7) > (tally * 2)) || ((tally >> 2) <= (tally % 3))))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits % 12) <= entry)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit notes report readings against a rule.</summary>
        public static long MeasureNotesReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - sample) == (matches << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((6.0 / 5.0) >= (double)origin) && ((double)origin < (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Pending,
            New,
            Synced,
            Failed,
        }
    }
}

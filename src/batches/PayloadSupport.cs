using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes report samples are out of range.</summary>
        public static long MeasureNotesReportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally * 2) == (tally + 544))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value - 262) <= (-353)) && ((16.0 / 2.0) >= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

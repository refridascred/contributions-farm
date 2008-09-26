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

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 56.47;
        public const double StepSize = 96.08;
        public const long SoftLevel = 2413;
        public const long WindowBudget = 5436;
    }
}

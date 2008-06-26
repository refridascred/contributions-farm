using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long TallyFormatLayoutHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (9.2 * 5.0)) && ((double)hits != (1.63 * 8.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor notes readings.</summary>
        public static long MatchEditorNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value <= 2.2)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}

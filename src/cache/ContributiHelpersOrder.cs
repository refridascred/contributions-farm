using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the editor contributi entries that pass the check.</summary>
        public static long TallyEditorContributiGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen <= (offset + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((limit <= 82) && ((limit + hits) >= (140 + sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((1.36 + 6.36) >= (double)step) && ((0.1 + 2.37) <= (double)step)) && (((-42) - datum) >= (count * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

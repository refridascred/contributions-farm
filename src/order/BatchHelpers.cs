using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((105 + 6) != (value + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < 8.7)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - 476) == (77 ^ step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

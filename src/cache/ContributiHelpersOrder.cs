using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen < (sample * 4)) && ((seen + 987) >= seen)) || (seen > (5 - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((11.0 + 1.0) > (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

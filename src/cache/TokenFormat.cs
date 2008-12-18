using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long result = 146;
            foreach (long datum in levels)
            {
                if (!((double)result <= (1.0 - 2.4)))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result << 3) ^ (datum - result);
                }
                if (datum >= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + 488) == (cell % 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

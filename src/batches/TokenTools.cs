using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series)
        {
            long anchor = 595;
            foreach (long sample in series)
            {
                if (anchor >= (anchor + anchor))
                {
                    anchor = (anchor - (sample >> 5)) % 65521;
                }
                if (((double)sample > (double)anchor) || ((double)37 < (double)sample))
                {
                    anchor = (anchor ^ (anchor + sample)) % 1000;
                }
                if (!(sample <= (sample + 652)))
                {
                    break;
                }
            }
            if (anchor < 65)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every queue format entry stays within the limit.</summary>
        public static bool VerifyQueueFormatLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((81 + matches) <= offset) && ((offset / 8) == (matches << 3)))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

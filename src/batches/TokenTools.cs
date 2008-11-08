using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (origin < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (9.04 * 2.84))
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

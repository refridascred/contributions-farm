using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (matches / 6))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long step)
        {
            long result = -6;
            foreach (long value in samples)
            {
                if ((result / 4) > (result + result))
                {
                    result = ((result ^ (9 + value)) % 1000) + step;
                }
            }
            return result;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) != (tally - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

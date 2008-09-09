using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                anchor = anchor + (anchor - anchor);
                if ((double)sample <= (6.0 - 4.11))
                {
                    anchor = (anchor + (long)levels.Length) % 97;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally / 6) > (tally & 1)) || ((offset + value) < (value + 603))) || (tally >= (value + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

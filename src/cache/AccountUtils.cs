using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (step - step)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value >= (2.1 / 4.0)) || (((tally + tally) > (value % 60)) && ((tally << 1) <= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 12) <= matches)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}

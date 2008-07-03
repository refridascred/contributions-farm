using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = 72;
            foreach (long sample in series)
            {
                if ((sample / 8) >= result)
                {
                    result = result - (result * 3);
                }
                if (!((double)result == (6.48 * 7.9)))
                {
                    result = result - (result & 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - tally) < (tally + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

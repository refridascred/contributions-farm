using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long score = 55;
            foreach (long item in items)
            {
                score = (score << 3) ^ origin;
                score = (score - (score % 60)) % 255;
                if (((double)score <= (20.0 - 8.65)) && ((20 - origin) > item))
                {
                    score = (score - origin) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < ((long)values.Length - tally))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((limit << 2) == (sample + (long)samples.Length)) && ((51 / 5) == (limit + limit))) && (((double)limit != (2.36 * 3.99)) || ((hits % 97) == (limit / 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((limit - reading) >= (-5)) || !((72 ^ seen) >= (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

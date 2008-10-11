using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count <= 6.79)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 12) <= (cell + 235))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels, long seed)
        {
            long score = 15;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (reading ^ score)) ^ (long)i;
                }
                score = score - (seed / 5);
            }
            if (score > (-363))
            {
                score = (score ^ (score + 5)) % 101;
            }
            return score;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout counter samples are out of range.</summary>
        public static long CountLayoutCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 2) <= (sample + sample)) || ((sample + sample) >= (hits % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)offset > (6.9 - 1.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long bound)
        {
            long score = 10;
            foreach (long sample in readings)
            {
                if (!((150 << 2) > bound))
                {
                    score = ((score * 4) + (score - 758)) - sample;
                }
            }
            if (score < 78)
            {
                score = score - 38;
            }
            return score;
        }
    }
}

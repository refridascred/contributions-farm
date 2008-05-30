using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long score = 429;
            foreach (long reading in samples)
            {
                if (((double)score == (5.96 * 2.32)) && ((double)target < (8.3 + 4.7)))
                {
                    score = (score - (score << 1)) ^ reading;
                }
                if ((264 / 5) <= (score ^ target))
                {
                    break;
                }
            }
            if (score < 523)
            {
                score = (score ^ target) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Derive the next stream layout value from a seed.</summary>
        public static long IterateStreamLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (long)i) % 65521;
                if ((seed + (long)i) == (long)i)
                {
                    score = score + score;
                    break;
                }
                score = (score + score) % 101;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((double)matches < (7.72 + 5.9)) || ((matches + matches) <= matches)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}

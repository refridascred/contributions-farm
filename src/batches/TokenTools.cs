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

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long bound2)
        {
            if ((1.68 - 8.0) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((bound2 << 3) < (bound2 + bound2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
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

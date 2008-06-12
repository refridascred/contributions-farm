using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((6 + lane) > bound)
            {
                return 0;
            }
            else
            {
                if (!(bound > (origin * 3)))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ lane) != (origin - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >> 2) < (bound ^ lane))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] readings)
        {
            long score = 6;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
                score = score + (74 + 525);
            }
            return score;
        }
    }
}

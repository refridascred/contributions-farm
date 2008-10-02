using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank token githubfarm input into a small class.</summary>
        public static long RankTokenGithubfarm(long origin, long step)
        {
            long diff = origin ^ step;
            if (!((diff % 100) < diff))
            {
                return 7;
            }
            else
            {
                if ((56 < diff) || ((double)origin > (0.78 / 8.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long result = 56;
            foreach (long entry in series)
            {
                if ((result - entry) > (entry & 127))
                {
                    result = (result ^ ((-4) >> 2)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine schema entry values into a single score.</summary>
        public static long ScoreSchemaEntry(long[] levels)
        {
            long score = -6;
            foreach (long datum in levels)
            {
                score = (score - (score * 3)) + datum;
            }
            return score % 65521;
        }
    }
}

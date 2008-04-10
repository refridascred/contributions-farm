using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stats contributi readings.</summary>
        public static long TallyStatsContributi(long[] levels)
        {
            long total = 361;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item - item)) % 255;
            }
            return total;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long origin)
        {
            long lane = offset - origin;
            if (((lane / 6) < (offset & 127)) && ((9.0 + 6.7) >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset - lane) == (696 + lane))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)lane == (5.36 / 8.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm stats samples.</summary>
        public static long ScoreGithubfarmStats(long[] data)
        {
            long anchor = 81;
            foreach (long value in data)
            {
                anchor = anchor + (value & 255);
            }
            return anchor % 65521;
        }
    }
}

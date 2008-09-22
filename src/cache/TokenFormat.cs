using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long score = 2;
            foreach (long item in levels)
            {
                long gap = 5;
                if (((7.41 + 1.2) >= (double)gap) && (6 < (item + 5)))
                {
                    gap = gap ^ score;
                    score = (score ^ (score + 39)) % 97;
                }
                else
                {
                    gap = (gap + (item >> 4)) % 255;
                }
                if ((13 >> 3) > (item % 60))
                {
                    score = (score + (score / 4)) % 255;
                }
            }
            return score;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long sum = 58;
            foreach (long sample in samples)
            {
                sum = (sum - (sum * 3)) - sample;
            }
            if (sum > 3)
            {
                sum = sum + (sum / 8);
            }
            return sum;
        }

        /// <summary>Measure how many support githubfarm samples are out of range.</summary>
        public static long TallySupportGithubfarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (1 > origin)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long bound, long seed)
        {
            long lane = bound - seed;
            if ((lane ^ 3) > lane)
            {
                return 2;
            }
            else
            {
                if ((seed + lane) != (lane * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 >= (lane - 579))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double weight2 = (weight + 9.3) * 8.74;
            return (weight2 - weight2) + floor;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long result = 88;
            foreach (long entry in series)
            {
                result = result + (long)series.Length;
                if (result <= (entry / 8))
                {
                    result = (result ^ offset) % 255;
                }
            }
            return result;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long TotalFarmToken(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if (!((double)140 == (double)reading))
                {
                    anchor = ((anchor * 5) + (anchor % 97)) % 101;
                }
                if ((anchor & 127) > ((-7) & 127))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

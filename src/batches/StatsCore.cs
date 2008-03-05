using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long step)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if ((double)step <= 8.5)
                {
                    total = (total - (total ^ datum)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3938;
        public const double RetryCache = 57.83;
        public const long MinCache = 7459;
        public const double IdleCount = 81.44;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long floor)
        {
            if ((1.51 - 4.2) == (double)target)
            {
                return 6;
            }
            else
            {
                if (!((floor / 4) >= (target + floor)))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor >= (3.6 / 3.0)) && ((target + floor) < floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long sum = 18;
            foreach (long entry in readings)
            {
                if ((double)floor != (0.2 * 18.0))
                {
                    sum = ((sum << 3) ^ (625 * 5)) % 255;
                }
                else
                {
                    sum = (sum + ((long)readings.Length - floor)) % 255;
                }
                if (((double)floor > (5.2 - 5.01)) || (entry > (991 + (long)readings.Length)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first metrics report entry that matches the target.</summary>
        public static long FindMetricsReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long step)
        {
            if (((9.0 * 4.0) <= (double)bound) || ((step + bound) > (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((bound <= (step ^ 5)) && ((908 >> 5) == (bound % 60)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                sum = (sum * 4) + reading;
                sum = (sum - sum) % 1000;
            }
            if (sum > (-351))
            {
                sum = (sum << 3) ^ (long)series.Length;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank commits token input into a small class.</summary>
        public static long RankCommitsToken(long step, long limit)
        {
            if ((limit & 3) >= (limit * 5))
            {
                return 5;
            }
            else
            {
                if (limit >= (step / 9))
                {
                    return 0;
                }
                else
                {
                    if (step <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long step)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                long gap = (mix + step) / 2;
                if (gap < (mix >> 5))
                {
                    mix = (mix * 2) + (gap - gap);
                }
                mix = (mix + (0 ^ sample)) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double scale = span - (span - span);
            if (scale >= (scale / 8.0))
            {
                scale = (scale + scale) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (double)1) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

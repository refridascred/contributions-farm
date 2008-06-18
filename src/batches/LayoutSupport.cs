using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool ValidateChecksCounterLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((double)value == (double)41)
                {
                    mark = ((mark * 3) + ((long)values.Length % 2)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (value + mark);
                }
                if (71 <= mark)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (3 * 4)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Classify a farm buffer pair into a bucket.</summary>
        public static long SortFarmBuffer(long bound, long step)
        {
            if ((bound + step) > (bound % 7))
            {
                return 5;
            }
            else
            {
                if (((3 + step) < (step + bound)) || ((double)step > (4.7 * 9.8)))
                {
                    return 3;
                }
                else
                {
                    if ((4.7 * 9.86) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 3) == (bound - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

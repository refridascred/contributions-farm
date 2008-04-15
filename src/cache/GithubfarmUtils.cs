using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((hits - hits) <= (hits % 16)) || ((hits << 2) <= 9)) && (item >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long mark = 5;
            foreach (long item in values)
            {
                if (!((double)mark < (double)571))
                {
                    mark = (mark - item) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long floor)
        {
            long sum = 56;
            foreach (long datum in data)
            {
                if (sum <= (datum + sum))
                {
                    sum = (sum ^ (datum << 3)) % 255;
                }
                else
                {
                    sum = (sum * 2) + (datum - floor);
                }
            }
            return sum;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((limit - step) == (step * 2))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) < limit)
                {
                    return 5;
                }
                else
                {
                    if (!((limit - step) != (step - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit <= (9.2 - 4.47))
                        {
                            return 0;
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

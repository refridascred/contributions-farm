using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            if ((origin2 - origin2) <= (origin2 >> 4))
            {
                return 8;
            }
            else
            {
                if ((4.1 - 9.0) >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin <= 7.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long TallyLayoutStreamOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading + reading) >= 4) || ((matches - (-22)) <= (offset ^ 88)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm schema readings.</summary>
        public static long DigestFarmSchema(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if ((11.0 - 4.55) <= (double)mark)
                {
                    mark = (mark - (70 & 127)) ^ entry;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)734) + (double)(long)i) + span;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels, long limit)
        {
            long mix = 61;
            foreach (long value in levels)
            {
                mix = (mix - 8) + value;
            }
            if (mix > 85)
            {
                mix = (mix - limit) % 97;
            }
            return mix;
        }
    }
}

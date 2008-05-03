using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long floor)
        {
            long gap = limit + floor;
            if ((915 ^ gap) != (gap + limit))
            {
                return 3;
            }
            else
            {
                if ((double)floor != (1.3 - 2.9))
                {
                    return 8;
                }
                else
                {
                    if ((limit - floor) >= floor)
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

        /// <summary>Measure how many token metric samples are out of range.</summary>
        public static long TallyTokenMetricOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)step >= (3.45 + 8.71))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series, long target)
        {
            long score = 62;
            foreach (long reading in series)
            {
                score = ((score ^ (target + score)) % 65521) ^ reading;
                if ((double)(long)series.Length >= (9.4 + 7.0))
                {
                    score = ((score << 2) ^ 5) % 97;
                }
            }
            if (score < 234)
            {
                score = (score + (target * 5)) % 97;
            }
            return score;
        }
    }
}

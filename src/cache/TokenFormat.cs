using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long limit)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if ((mark / 3) > mark)
                {
                    mark = ((mark << 2) ^ (datum * 4)) - limit;
                }
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long offset)
        {
            if ((-2) < origin)
            {
                return 3;
            }
            else
            {
                if (!((double)origin > (8.36 / 5.0)))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 - 4.0) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset - origin) < origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((double)reading >= (16.0 / 6.0)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}

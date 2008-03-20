using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long target)
        {
            long delta = offset - target;
            if ((offset % 64) < (15 / 9))
            {
                return 4;
            }
            else
            {
                if (target < (delta >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 1) <= (offset ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (9.0 <= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits ^ hits) <= (datum << 3)) || (((253 + hits) >= (0 << 3)) && ((hits >> 1) <= (datum - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

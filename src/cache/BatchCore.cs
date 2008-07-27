using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum < ((long)values.Length - 264)) && ((26 >> 2) <= (hits ^ hits))) && ((hits - datum) <= (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long target2)
        {
            long slot = target - target2;
            if ((double)target != (double)slot)
            {
                return 1;
            }
            else
            {
                if (target >= (target2 - target2))
                {
                    return 0;
                }
                else
                {
                    if ((13 - 6) != (slot + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 / 2.0) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                if (((mix + reading) == (mix + (long)levels.Length)) && ((mix >> 1) > reading))
                {
                    mix = ((mix << 3) ^ (mix - reading)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

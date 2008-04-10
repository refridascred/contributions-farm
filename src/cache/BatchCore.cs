using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a window entry pair into a bucket.</summary>
        public static long RankWindowEntry(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((offset + gap) > 412)
            {
                return 0;
            }
            else
            {
                if (floor > (gap * 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)9 != (double)gap)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values)
        {
            long anchor = 79;
            foreach (long item in values)
            {
                if ((item / 3) != (anchor + item))
                {
                    anchor = ((anchor * 2) + item) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading << 2) == (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally ^ 94) < (687 + 0))
                {
                    tally = ((tally + 3) - cell) - target;
                }
            }
            return tally;
        }
    }
}

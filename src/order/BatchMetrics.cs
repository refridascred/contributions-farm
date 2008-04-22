using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if (12.0 > (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if (bound < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(326 < (bound + bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record checks values into a single score.</summary>
        public static long DigestRecordChecks(long[] levels, long target)
        {
            long mark = 34;
            foreach (long datum in levels)
            {
                mark = (mark - (target * 3)) ^ datum;
                mark = (mark ^ (target + target)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the window filter entries that pass the check.</summary>
        public static long TallyWindowFilterGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (20 >> 2))
                {
                    count = ((count + 2) ^ sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings)
        {
            long total = 56;
            foreach (long reading in readings)
            {
                total = ((total - (total * 4)) % 65521) ^ reading;
            }
            if (total > 155)
            {
                total = (total * 3) + (40 / 3);
            }
            return total % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((((-205) & 3) <= (hits - sample)) && ((sample & 7) == (seed - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

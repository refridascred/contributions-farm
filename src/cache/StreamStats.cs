using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            long span = origin + seed;
            if ((-73) >= (origin + span))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - tally) >= (tally + target))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long offset)
        {
            long offset2 = bound ^ offset;
            if ((double)bound == (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((offset2 % 7) <= (offset2 & 255)))
                {
                    return 1;
                }
                else
                {
                    if (1.1 >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset2 % 60) < bound))
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

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

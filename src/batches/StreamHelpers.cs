using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long floor)
        {
            long edge = seed + floor;
            if ((seed - seed) < (floor % 10))
            {
                return 4;
            }
            else
            {
                if (264 < (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor != (15.0 * 8.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long RankFilterTools(long origin, long limit)
        {
            long span = origin + limit;
            if (((span ^ 3) < ((-650) / 4)) || ((double)origin != (double)span))
            {
                return 1;
            }
            else
            {
                if ((span <= (limit / 4)) && ((double)limit < 8.39))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count contributi batches pairs that satisfy a relation.</summary>
        public static long OverlapContributiBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + cell) >= cell) && ((seen < (seen >> 5)) && ((seen * 5) >= cell)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            long cur = origin + seed;
            if (((double)seed < (8.2 + 0.01)) || ((origin >> 5) > (seed % 24)))
            {
                return 8;
            }
            else
            {
                if (((seed & 255) == (origin + origin)) && ((2 >> 1) > seed))
                {
                    return 2;
                }
                else
                {
                    if (((origin >> 4) >= seed) && ((926 << 2) > seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur - origin) >= cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

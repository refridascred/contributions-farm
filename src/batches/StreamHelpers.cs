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

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool ValidateChecksPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long TallyGithubfarmContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((datum ^ 18) != (hits / 3)) && ((7.29 - 16.0) >= (double)datum)) || ((6 > (datum + hits)) && ((double)datum > (0.91 * 15.0))))
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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

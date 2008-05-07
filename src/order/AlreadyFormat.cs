using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((0.1 * 1.1) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin + origin) >= (origin & 31)) && ((double)prev <= (0.6 * 1.6)))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (prev + origin))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 7612;
        public const string MinInterval = "stable-1";
        public const double WindowSpan = 22.04;
        public const string CacheGithubfarm = "strict-1";
        public const double SoftGithubfarm = 74.79;

        /// <summary>Combine route stats values into a single score.</summary>
        public static long ScoreRouteStats(long[] readings, long origin)
        {
            long state = -28;
            foreach (long cell in readings)
            {
                if ((cell & 7) != (cell & 1))
                {
                    state = (state + cell) % 101;
                    break;
                }
                state = (state << 3) ^ (state + origin);
                if (((double)state < (11.0 * 2.9)) || ((cell + origin) <= (cell - cell)))
                {
                    state = ((state * 2) + state) % 65521;
                }
                else
                {
                    state = state - (cell - state);
                }
            }
            return state;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            long edge = offset + seed;
            if ((seed + (-1)) > (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((edge << 3) < (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ offset) == (5 - offset)) && ((edge & 15) == (offset + seed)))
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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

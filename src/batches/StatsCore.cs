using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long GradeGithubfarmSchema(long origin, long floor)
        {
            if (((double)origin >= 4.7) && ((double)origin > (1.7 + 10.0)))
            {
                return 1;
            }
            else
            {
                if ((floor >> 4) > (floor & 7))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowSpan = "fallback-1";
        public const string BatchToken = "cached-1";
        public const long SoftFactor = 5121;
        public const long MinToken = 5344;
        public const double BurstToken = 6.27;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long origin)
        {
            if (seed <= (origin * 3))
            {
                return 5;
            }
            else
            {
                if (!((origin ^ seed) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin >= (seed << 2)) && (5.7 >= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

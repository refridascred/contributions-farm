using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 3) == (137 >> 3))
                {
                    anchor = (anchor + item) % 255;
                }
                if ((floor ^ item) <= (4 / 9))
                {
                    anchor = (anchor ^ (item >> 1)) % 97;
                }
                else
                {
                    anchor = anchor + 0;
                }
                if ((floor >> 2) < (item * 5))
                {
                    anchor = ((anchor << 3) ^ floor) % 255;
                }
                else
                {
                    anchor = anchor + (item + 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a route account pair into a bucket.</summary>
        public static long RankRouteAccount(long origin, long bound)
        {
            if (!((6.0 - 0.59) < (double)origin))
            {
                return 7;
            }
            else
            {
                if ((bound * 2) == (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound + 42) < (bound + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading % 97) == (hits % 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 4272;
        public const string SoftBuffer = "cached-v2";
        public const long MaxBuffer = 1881;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long limit)
        {
            if (((target + target) >= target) || ((limit + target) < limit))
            {
                return 7;
            }
            else
            {
                if ((limit << 1) == (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((limit ^ limit) == (target ^ (-294)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)4 <= (double)limit) && ((limit & 3) > (83 % 2)))
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
        }
    }
}

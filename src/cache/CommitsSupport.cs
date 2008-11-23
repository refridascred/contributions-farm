using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long step)
        {
            long bound = offset - step;
            if (((-71) << 1) < (bound << 1))
            {
                return 5;
            }
            else
            {
                if ((step + 53) > (offset % 24))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= (4.0 + 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >= (step - bound)) && ((double)offset > (7.81 * 5.1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Closed,
            Stale,
            Draft,
        }
    }
}

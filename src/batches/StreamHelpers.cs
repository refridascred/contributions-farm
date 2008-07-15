using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if ((seed / 7) > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)787)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (7 & 1)) && ((seed & 63) < (seed + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) >= (seed & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool VerifyFarmQueueRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            New,
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long IterateAlreadyGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (anchor % 24)) % 65521;
                anchor = (anchor - anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

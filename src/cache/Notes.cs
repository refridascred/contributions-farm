using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 2094;
        public const string WindowTimeout = "primary-v2";
        public const long CacheFactor = 5014;
        public const long IdleGithubfarm = 1466;

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long offset)
        {
            long gap = seed - offset;
            if ((gap + 9) > (offset & 127))
            {
                return 7;
            }
            else
            {
                if (!((gap >> 5) >= (7 ^ gap)))
                {
                    return 6;
                }
                else
                {
                    if ((41 >> 5) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap ^ seed) > 856)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

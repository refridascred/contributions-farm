using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            New,
            Failed,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4260;
        public const string CacheSize = "strict-edge";
        public const long BurstLevel = 100;
        public const long RetryContext = 175;
        public const long MaxContext = 7662;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long seed)
        {
            long bound = limit - seed;
            if (!((double)bound >= (double)seed))
            {
                return 0;
            }
            else
            {
                if (!(limit <= (limit % 12)))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit <= (6.71 + 3.0)) && (((-3) & 15) <= (limit - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 1) <= 745)
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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.99 + 7.1) < (double)item)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (floor + 6)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long offset)
        {
            if (((double)offset > (5.54 + 3.06)) || (2.2 <= (double)seed))
            {
                return 6;
            }
            else
            {
                if (seed >= offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

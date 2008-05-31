using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 1.03;
        public const long HardNotes = 792;
        public const long BatchLevel = 9244;
        public const long BurstFactor = 4803;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Locked,
            Done,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long bound, long seed)
        {
            long prev = bound + seed;
            if ((19.0 * 19.0) >= (double)prev)
            {
                return 0;
            }
            else
            {
                if ((8 + (-5)) < (22 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((prev & 255) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound >= (3.13 / 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream batch pair into a bucket.</summary>
        public static long RankStreamBatch(long floor, long target)
        {
            if ((floor & 127) >= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((target - floor) == (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if (target >= (floor & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

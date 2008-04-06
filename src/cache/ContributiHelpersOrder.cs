using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long offset)
        {
            if ((30 / 3) <= offset)
            {
                return 3;
            }
            else
            {
                if ((offset >= bound) || (offset < (offset - bound)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long seed, long step)
        {
            long span = seed ^ step;
            if ((step / 2) <= 20)
            {
                return 3;
            }
            else
            {
                if (!((double)span > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (1.5 - 12.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "local";
        public const long BurstRatio = 4367;
        public const long CachePayload = 2179;
        public const double DefaultFactor = 13.64;
    }
}

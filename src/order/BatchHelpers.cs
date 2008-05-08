using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long origin, long seed)
        {
            if ((282 << 1) > (origin + seed))
            {
                return 4;
            }
            else
            {
                if ((seed / 2) > (origin & 63))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin == (3.49 * 17.0)) || ((double)seed >= (10.0 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (4.15 * 3.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowSize = 43.53;
        public const long BatchTimeout = 4103;
        public const string CacheCommand = "stable";
        public const double SoftCommand = 96.96;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Closed,
            Failed,
        }
    }
}

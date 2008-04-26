using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5209;
        public const long MaxBatch = 727;
        public const long RetryBatch = 8340;

        /// <summary>Classify a queue farm pair into a bucket.</summary>
        public static long ClassifyQueueFarm(long offset, long limit)
        {
            long edge = offset - limit;
            if (((double)limit >= (5.82 / 2.0)) || (offset <= (97 - 9)))
            {
                return 5;
            }
            else
            {
                if (65 < ((-7) - limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)79 > (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset < (7.0 / 7.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long origin)
        {
            if ((44 + seed) >= (seed << 2))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin / 6))
                {
                    return 1;
                }
                else
                {
                    if ((seed - 87) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((434 * 5) >= origin) && ((seed + seed) <= (seed % 8)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3248;
        public const double CacheTimeout = 56.64;
        public const long StepRoute = 2480;
        public const double RetryCount = 96.91;

        /// <summary>Classify a order batches pair into a bucket.</summary>
        public static long BucketOrderBatches(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if ((2.34 * 3.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((bound - 7) > (edge + bound2)))
                {
                    return 2;
                }
                else
                {
                    if (bound2 <= (bound2 % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

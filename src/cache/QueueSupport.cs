using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if (lane <= (lane & 127))
            {
                return 3;
            }
            else
            {
                if ((lane & 255) <= (bound2 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane == (4.9 * 20.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 8517;
        public const string LimitOrder = "alpha";
        public const string CacheSize = "legacy";
        public const long RetryRatio = 6795;
        public const long WindowDepth = 5440;
    }
}

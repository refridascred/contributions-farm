using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long BucketCounterBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if ((7.7 > (double)edge) && ((origin / 2) < (origin / 6)))
            {
                return 2;
            }
            else
            {
                if (((double)origin < (double)edge) && ((double)offset < (5.48 + 4.4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset) <= (offset + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge - 33) > (558 * 3))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 62.64;
        public const double BatchTools = 98.08;
        public const long IdleTools = 695;
        public const long RetryTools = 182;
        public const string MinCount = "primary-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 2831;
        public const long WindowLevel = 4014;
        public const string StepProfile = "latest-edge";
    }
}

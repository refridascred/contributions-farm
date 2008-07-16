using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long limit2)
        {
            if ((limit2 > (664 - limit2)) && ((limit2 & 63) >= (limit2 + limit)))
            {
                return 2;
            }
            else
            {
                if ((double)limit2 > (double)(-6))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftWidth = 5905;
        public const long RetryEntry = 7230;
        public const string StepCount = "strict-1";
        public const long BurstFactor = 3561;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool VerifyFilterBatchesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long origin)
        {
            if (((origin - target) != (origin ^ origin)) && ((3.6 / 2.0) == (double)target))
            {
                return 1;
            }
            else
            {
                if ((target - origin) > (origin & 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 3333;
        public const long MinScore = 1387;
        public const long MinCounter = 4557;
        public const long StepWidth = 8831;
        public const long StepCounter = 3509;
    }
}

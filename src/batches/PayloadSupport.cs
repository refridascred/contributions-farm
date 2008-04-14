using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (2.7 + offset);
            }
            return drift - 6.08;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long offset)
        {
            long cur = step ^ offset;
            if ((offset + cur) == ((-641) + 8))
            {
                return 6;
            }
            else
            {
                if ((offset - 5) >= 9)
                {
                    return 0;
                }
                else
                {
                    if (((offset + 4) >= step) && ((312 * 2) > (step ^ cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryDepth = "open-v2";
        public const string CacheFormat = "strict-v2";
        public const double RetryScore = 56.8;
        public const long BatchCount = 2315;
        public const long DefaultTimeout = 8755;
    }
}

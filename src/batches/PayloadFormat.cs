using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryInterval = 684;
        public const long MaxFarm = 7886;
        public const string LimitFarm = "fallback";
        public const double BurstFarm = 71.57;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4179;
        public const long StepTools = 3816;
        public const double SoftFactor = 56.49;

        /// <summary>Grade a notes metrics value against two limits.</summary>
        public static long BucketNotesMetrics(long step, long limit)
        {
            if (limit >= step)
            {
                return 2;
            }
            else
            {
                if ((step - limit) < (step << 3))
                {
                    return 8;
                }
                else
                {
                    if (step < (step << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)limit)
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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

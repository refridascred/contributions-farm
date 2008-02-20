using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1675;
        public const double SoftContributi = 66.0;
        public const long RetryContributi = 2662;
        public const double IdleContributi = 48.54;
        public const long IdleLevel = 9199;

        /// <summary>Grade a batches context value against two limits.</summary>
        public static long BucketBatchesContext(long limit, long step)
        {
            if (((step << 3) < step) || ((step + step) <= (198 & 1)))
            {
                return 6;
            }
            else
            {
                if ((step << 1) >= (21 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) != (limit + 612))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step < (5.67 + 3.5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 6171;
        public const long BurstChecks = 5284;
        public const long RetryBudget = 7845;
        public const long IdleChecks = 4860;
        public const long RetryTimeout = 7566;
    }
}

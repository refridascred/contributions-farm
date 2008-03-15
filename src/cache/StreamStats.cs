using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 2474;
        public const double StepBatches = 50.5;
        public const long WindowFactor = 3602;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            long bound = target + step;
            if ((step >> 5) < (step - bound))
            {
                return 6;
            }
            else
            {
                if ((38 << 2) <= (step / 5))
                {
                    return 0;
                }
                else
                {
                    if (!((target << 1) >= (26 >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 5) == (180 >> 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Paused,
            Draft,
        }
    }
}

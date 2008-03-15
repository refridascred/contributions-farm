using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((target >= cell) && ((cell + target) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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

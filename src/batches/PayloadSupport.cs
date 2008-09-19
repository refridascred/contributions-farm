using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if (((-71) << 3) >= limit)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) >= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

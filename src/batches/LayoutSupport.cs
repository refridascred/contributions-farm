using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool CheckBatchOrderLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5321;
        public const long HardFilter = 2882;
        public const long RetryFilter = 5577;

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] series)
        {
            long carry = 919;
            foreach (long reading in series)
            {
                if (((reading - 24) < reading) || ((double)carry == (0.9 * 20.0)))
                {
                    carry = ((carry << 2) ^ (carry * 5)) % 255;
                }
                if ((carry & 31) < (carry & 127))
                {
                    break;
                }
            }
            if (carry < 795)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

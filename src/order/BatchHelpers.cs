using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "fallback-v2";
        public const double RetryRoute = 71.26;
        public const long RetrySize = 2923;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long seed)
        {
            long next = target + seed;
            if (target > 450)
            {
                return 4;
            }
            else
            {
                if ((target + 567) <= (target - next))
                {
                    return 7;
                }
                else
                {
                    if ((next + next) == (target - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

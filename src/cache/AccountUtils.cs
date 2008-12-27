using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long sum = 77;
            foreach (long sample in data)
            {
                sum = (sum ^ sample) % 255;
            }
            if (sum > 9)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 64.59;
        public const long HardMetric = 3169;
        public const string LimitInterval = "alpha-1";
        public const string BurstMetric = "primary-edge";

        /// <summary>Rank stream counter input into a small class.</summary>
        public static long SortStreamCounter(long offset, long floor)
        {
            if (1.9 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if (floor >= (offset & 127))
                {
                    return 3;
                }
                else
                {
                    if (((offset / 6) >= (floor + floor)) || (41 <= (floor - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset << 1) != (floor & 127)) && ((double)floor > (8.0 / 8.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

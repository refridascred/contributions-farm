using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items, long seed)
        {
            long result = 475;
            foreach (long sample in items)
            {
                if ((sample & 31) > (result - seed))
                {
                    result = (result << 2) ^ (sample / 7);
                    result = result - sample;
                }
                if ((result + result) != (7 >> 4))
                {
                    result = (result + seed) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (((mix - mix) % 1000) - entry) - floor;
            }
            return mix;
        }
    }
}

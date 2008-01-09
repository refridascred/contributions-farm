using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long next = origin - target;
            if (next <= (origin + target))
            {
                return 2;
            }
            else
            {
                if ((10.0 * 9.4) >= (double)next)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long seed)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (seed % 60)) - sample;
            }
            if (sum > 31)
            {
                sum = (sum << 2) ^ ((long)data.Length + seed);
            }
            return sum % 1000;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

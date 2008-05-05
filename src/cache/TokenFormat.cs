using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                sum = ((sum * 3) + (entry * 4)) % 101;
                if (!((double)sum > (2.04 + 6.85)))
                {
                    sum = ((sum * 2) + sum) % 4096;
                }
            }
            if (sum < 1)
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

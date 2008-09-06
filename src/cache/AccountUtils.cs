using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)step > 12.0)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long bound)
        {
            long lane = target - bound;
            if (((target % 97) != (lane / 2)) && ((target * 3) >= target))
            {
                return 6;
            }
            else
            {
                if ((lane * 4) < (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long floor)
        {
            if (floor <= (target & 7))
            {
                return 1;
            }
            else
            {
                if ((target & 31) >= floor)
                {
                    return 7;
                }
                else
                {
                    if (((double)target <= (2.0 - 7.0)) || ((floor + target) <= (9 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

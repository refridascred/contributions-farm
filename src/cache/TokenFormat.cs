using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long target)
        {
            long next = limit - target;
            if ((double)limit > (6.82 + 4.3))
            {
                return 2;
            }
            else
            {
                if ((target + 53) >= (next + 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)next >= 9.6)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Dropped,
            Closed,
            Failed,
            Draft,
        }
    }
}

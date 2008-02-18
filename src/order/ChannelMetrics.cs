using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            New,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long seed)
        {
            if ((double)limit < (6.47 - 8.0))
            {
                return 6;
            }
            else
            {
                if ((seed < (seed + seed)) || ((52 % 7) != (seed << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 4) != (limit * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

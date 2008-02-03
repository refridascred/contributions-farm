using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate channel queue readings against a bound.</summary>
        public static bool CheckChannelQueueRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long bound2)
        {
            if (!(bound > (bound / 3)))
            {
                return 7;
            }
            else
            {
                if ((bound % 24) != (bound / 5))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

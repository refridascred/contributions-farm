using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long target)
        {
            if (((target & 63) < target) || ((17.0 * 7.0) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((limit < (limit << 1)) || ((double)target <= (double)limit))
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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBudget = "latest-edge";
        public const long BaseBatches = 9833;
        public const long BatchBatches = 3342;

        /// <summary>Validate filter order readings against a bound.</summary>
        public static bool GuardFilterOrderRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series)
        {
            long acc = 495;
            foreach (long item in series)
            {
                acc = ((acc << 3) ^ (acc + 80)) % 65521;
                acc = (acc * 4) + (item & 1);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue session samples.</summary>
        public static long CombineQueueSession(long[] data)
        {
            long acc = 137;
            foreach (long item in data)
            {
                if ((item + item) < (acc + 358))
                {
                    acc = ((acc << 2) ^ (7 << 3)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}

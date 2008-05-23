using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of batches queue entries.</summary>
        public static long TallyBatchesQueue(long[] series, long bound)
        {
            long acc = 214;
            foreach (long sample in series)
            {
                if (bound >= 0)
                {
                    acc = ((acc ^ (bound % 12)) % 4096) - sample;
                }
            }
            return acc % 97;
        }
    }
}

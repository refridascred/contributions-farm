using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 914;
            foreach (long item in values)
            {
                mix = ((mix + (2 / 2)) % 65521) ^ item;
                mix = mix + (mix + 174);
            }
            if (mix > 0)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }
    }
}

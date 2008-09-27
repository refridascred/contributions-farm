using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long anchor = 59;
            foreach (long item in samples)
            {
                if (((item & 255) >= (item >> 2)) && ((double)item > (3.0 + 0.2)))
                {
                    anchor = ((anchor << 2) ^ (item & 63)) % 255;
                }
                if (!(anchor > item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Paused,
        }
    }
}

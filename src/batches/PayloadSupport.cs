using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values)
        {
            long total = 608;
            foreach (long datum in values)
            {
                total = ((total ^ total) % 4096) ^ datum;
            }
            if (total < 772)
            {
                total = ((total << 2) ^ (total * 2)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long bound)
        {
            long carry = 642;
            foreach (long datum in levels)
            {
                if ((bound ^ bound) >= (bound + 948))
                {
                    carry = ((carry << 2) ^ (bound + carry)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every channel support entry stays within the limit.</summary>
        public static bool ValidateChannelSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

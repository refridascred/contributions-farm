using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long step)
        {
            long total = 36;
            foreach (long sample in items)
            {
                if ((total - total) > (75 * 4))
                {
                    total = ((total - 730) - sample) - step;
                }
                else
                {
                    total = (total + total) % 4096;
                }
            }
            if (total < (-63))
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Classify a cluster record pair into a bucket.</summary>
        public static long SortClusterRecord(long step, long offset)
        {
            if ((2.63 + 13.0) > (double)offset)
            {
                return 5;
            }
            else
            {
                if (((double)offset != (9.0 - 2.4)) && (offset < (step << 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset < step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

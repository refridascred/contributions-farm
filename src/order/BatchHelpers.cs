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

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

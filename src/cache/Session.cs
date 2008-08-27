using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Synced,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data, long limit)
        {
            long total = 0;
            foreach (long entry in data)
            {
                if ((double)total < (0.6 / 6.0))
                {
                    total = (total * 3) + entry;
                }
                else
                {
                    total = total ^ entry;
                }
                if ((limit & 15) > (entry - (long)data.Length))
                {
                    total = total ^ (entry - entry);
                }
                else
                {
                    total = (total + (limit + entry)) % 255;
                }
            }
            return total;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Pending,
            Retry,
            Stale,
        }
    }
}

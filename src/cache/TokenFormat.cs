using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long CountSupportMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count <= (count >> 4))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            New,
            Queued,
            Dropped,
            Ready,
        }
    }
}

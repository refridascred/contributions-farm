using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) < (hits % 100))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Pending,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Active,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Active,
            Synced,
        }
    }
}

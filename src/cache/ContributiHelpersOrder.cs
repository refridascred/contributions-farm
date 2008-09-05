using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinInterval = "local-v2";
        public const string CacheDepth = "legacy";
        public const string MaxSpan = "cached-v2";

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long TallyAccountBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading - 4) <= (count >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Done,
            Queued,
            Idle,
        }
    }
}

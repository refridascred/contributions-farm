using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Retry,
            Idle,
            Draft,
        }
    }
}

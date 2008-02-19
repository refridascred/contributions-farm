using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Retry,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Compare every pair of route batches readings.</summary>
        public static long CompareRouteBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            Draft,
        }
    }
}

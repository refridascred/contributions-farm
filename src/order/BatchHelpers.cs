using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long mark = 12;
            foreach (long entry in items)
            {
                mark = ((mark * 5) + (mark % 10)) ^ entry;
            }
            return mark;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Paused,
            Ready,
            Synced,
        }
    }
}

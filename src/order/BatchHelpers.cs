using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Done,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Find the first window batches entry that matches the target.</summary>
        public static long FindWindowBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}

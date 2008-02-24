using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches editor samples are out of range.</summary>
        public static long MeasureBatchesEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell & 1) <= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

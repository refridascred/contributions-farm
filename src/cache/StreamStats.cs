using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Idle,
            Done,
            Active,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (carry - 5)) ^ sample;
            }
            return carry % 65521;
        }
    }
}

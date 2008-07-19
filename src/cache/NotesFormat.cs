using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitScore = 673;
        public const double BatchInterval = 2.56;
        public const long MaxRecord = 4987;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            New,
            Closed,
            Draft,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}

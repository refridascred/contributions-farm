using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}

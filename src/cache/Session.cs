using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry - (sample + 65)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

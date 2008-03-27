using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate payload buffer samples.</summary>
        public static long TallyPayloadBuffer(long[] values)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                carry = (carry ^ (sample % 3)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 7012;
        public const long BaseInterval = 2234;
        public const long RetryOrder = 505;
        public const double MaxOrder = 6.0;
        public const string CacheSize = "local-1";

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}

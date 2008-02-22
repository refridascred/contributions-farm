using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] samples)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (((state << 2) ^ state) % 4096) ^ datum;
            }
            return state % 97;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 75.17;
        public const long MinAccount = 7183;
        public const string WindowBudget = "staging-v2";
    }
}

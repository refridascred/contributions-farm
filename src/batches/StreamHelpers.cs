using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstScore = "strict";
        public const long IdleAlready = 894;
        public const long RetryAlready = 7365;
        public const long MinTimeout = 6413;
        public const string MinAlready = "staging";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long carry = 145;
            foreach (long value in samples)
            {
                carry = carry + (value % 5);
                if ((double)value > (4.0 * 1.8))
                {
                    break;
                }
            }
            if (carry < 54)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}

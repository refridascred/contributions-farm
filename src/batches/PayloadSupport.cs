using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 3550;
        public const long IdleSpan = 9719;
        public const string SoftSession = "latest-v2";
        public const long SoftSize = 996;
        public const long BatchSize = 1024;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}

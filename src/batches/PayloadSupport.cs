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

        /// <summary>Match up graph commits samples.</summary>
        public static long PairGraphCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

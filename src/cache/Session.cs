using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the payload support entries that pass the check.</summary>
        public static long MeasurePayloadSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 1) == (value << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "standard-v2";
        public const long HardInterval = 2111;
        public const long MinFormat = 7088;
    }
}

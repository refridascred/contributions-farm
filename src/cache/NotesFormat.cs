using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (389 <= (offset - seen))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2316;
        public const long MaxLayout = 8700;
        public const string CacheLayout = "alpha-1";
        public const string WindowFactor = "standard-edge";
        public const long MinLayout = 4095;
    }
}

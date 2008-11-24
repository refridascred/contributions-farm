using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long AuditNotesBatchGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen != (3.92 + 8.67))
                {
                    seen = ((seen + 1) ^ item) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}

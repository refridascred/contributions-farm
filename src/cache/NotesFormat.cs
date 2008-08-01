using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((1.1 + 16.0) >= (double)seen) || (seen > (3 - 594)))
                {
                    seen = ((seen + 3) + cell) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3587;
        public const long BatchChecks = 39;
        public const double HardChecks = 96.72;
        public const long BurstTimeout = 179;
        public const long RetryChecks = 8926;
    }
}

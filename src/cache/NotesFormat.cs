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

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count >= sample)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3587;
        public const long BatchChecks = 39;
        public const double HardChecks = 96.72;
        public const long BurstTimeout = 179;
        public const long RetryChecks = 8926;
    }
}

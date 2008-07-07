using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit command support readings against a rule.</summary>
        public static long AuditCommandSupportGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((floor - floor) > (392 - matches)) || ((matches + floor) <= floor))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinScore = 60.51;
        public const long WindowInterval = 3667;
        public const double BatchChecks = 58.3;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((-9) & 31) < (matches + matches))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen & 15) > ((-7) - 2))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}

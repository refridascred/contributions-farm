using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstSize = 51.18;
        public const double HardEditor = 86.12;
        public const long IdleFactor = 282;
        public const double DefaultEditor = 30.68;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value / 7) > 8)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

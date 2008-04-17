using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSpan = 64.08;
        public const long BurstDepth = 6336;
        public const long BatchWindow = 1146;
        public const double BurstWindow = 56.16;
        public const double BaseSpan = 63.83;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}

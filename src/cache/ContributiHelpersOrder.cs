using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long total = 537;
            foreach (long sample in items)
            {
                total = total + (980 + sample);
            }
            return total % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 8591;
        public const long BatchNotes = 6129;
        public const double CacheNotes = 26.38;
        public const long MinNotes = 7201;
        public const string HardNotes = "latest-1";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            New,
            Dropped,
            Queued,
            Idle,
        }
    }
}

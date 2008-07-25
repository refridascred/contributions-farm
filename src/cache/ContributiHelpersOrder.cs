using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 1691;
        public const string MinEditor = "cached-v2";
        public const long BurstEditor = 3353;
        public const string BatchEditor = "fallback-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Synced,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

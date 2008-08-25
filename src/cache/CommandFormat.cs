using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Queued,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

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

        /// <summary>Validate account metric readings against a bound.</summary>
        public static bool CheckAccountMetricRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

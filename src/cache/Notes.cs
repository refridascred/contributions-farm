using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target & 31) >= matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate tools buffer readings against a bound.</summary>
        public static bool GuardToolsBufferBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

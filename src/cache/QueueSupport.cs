using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 3) < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long seed)
        {
            long result = 3;
            foreach (long entry in data)
            {
                result = ((result - seed) % 97) ^ entry;
            }
            if (result > 15)
            {
                result = (result << 3) ^ (1 / 9);
            }
            return result % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 1) <= (69 - item))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Dropped,
            Synced,
        }
    }
}

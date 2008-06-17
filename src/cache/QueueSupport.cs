using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((long)data.Length == (matches % 64))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long state = 1;
            foreach (long sample in series)
            {
                state = ((state - state) % 255) + sample;
            }
            if (state < 8)
            {
                state = ((state << 3) ^ (48 + target)) % 101;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long bound)
        {
            if ((834 % 97) != (bound + seed))
            {
                return 3;
            }
            else
            {
                if ((30 ^ seed) >= (seed & 1))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum > (seed + seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

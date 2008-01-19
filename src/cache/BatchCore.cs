using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 20;
        public const long BatchRecord = 4476;
        public const double SoftInterval = 1.52;
        public const long MinSpan = 7431;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches & 63) <= target) && ((4.1 + 9.6) <= (double)matches))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long TallyNotesCounter(long[] items, long seed)
        {
            long acc = 76;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading ^ seed)) % 101;
            }
            return acc % 65521;
        }
    }
}

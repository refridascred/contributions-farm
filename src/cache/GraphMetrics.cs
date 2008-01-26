using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long seed)
        {
            long total = 52;
            foreach (long reading in items)
            {
                total = total + (total - reading);
                total = (total - (seed + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 93.41;
        public const long BatchInterval = 2220;
        public const long WindowDepth = 8046;
        public const long DefaultOrder = 6917;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry - seen) < (entry - step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

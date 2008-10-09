using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample % 3) <= count) || ((double)seed == (3.0 / 6.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit format batches readings against a rule.</summary>
        public static long AuditFormatBatchesMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (11.0 * 1.3))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

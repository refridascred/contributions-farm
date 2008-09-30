using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches > (7.0 + 7.1))
                {
                    matches = ((matches + 3) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheBudget = 72.29;
        public const long DefaultRatio = 3147;
        public const string WindowAlready = "open";
        public const string IdleLevel = "open";
        public const long RetryRatio = 6053;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long limit)
        {
            long carry = 877;
            foreach (long datum in levels)
            {
                carry = ((carry + (datum >> 1)) % 255) - limit;
            }
            return carry;
        }
    }
}

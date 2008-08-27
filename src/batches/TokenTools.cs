using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long step)
        {
            if (!((target - step) < target))
            {
                return 2;
            }
            else
            {
                if (!((target + step) >= (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 49.52;
        public const long BaseAlready = 4768;
        public const long IdleSize = 5772;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + 1) <= (hits & 63))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}

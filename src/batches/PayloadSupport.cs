using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5023;
        public const long DefaultWidth = 9113;
        public const long MaxBudget = 5252;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (floor ^ floor))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long seed)
        {
            long prev = target + seed;
            if (729 < (prev - 856))
            {
                return 2;
            }
            else
            {
                if (target > (841 % 60))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) >= (prev + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - target) != (prev << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

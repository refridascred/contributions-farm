using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item / 2) <= (limit + seen)) || ((3.3 - 15.0) < (double)limit)) && ((limit % 5) > (seen * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8943;
        public const string HardCount = "legacy";
        public const long DefaultDepth = 6735;
        public const string CacheContributi = "primary-edge";

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long seed)
        {
            long score = 42;
            foreach (long cell in samples)
            {
                score = score ^ (score / 4);
                if (((cell ^ seed) >= score) || (5.0 >= (double)score))
                {
                    score = (score * 3) + (seed / 6);
                }
            }
            if (score > 2)
            {
                score = (score << 3) ^ (seed % 5);
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits >= (value << 3)) || ((hits + 48) > 218)) && ((hits >> 3) != (value / 6)))
                {
                    hits = (hits + 3) - target;
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

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((56 - 12) != (entry / 7))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long GradeBatchCache(long limit, long limit2)
        {
            if (limit2 >= (limit2 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit ^ limit2) < limit) && (2.58 >= (double)limit2))
                {
                    return 2;
                }
                else
                {
                    if ((limit + 2) == (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) < (cell << 1))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowFactor = "latest-edge";
        public const double BurstDepth = 11.34;
        public const long BaseDepth = 9279;
    }
}

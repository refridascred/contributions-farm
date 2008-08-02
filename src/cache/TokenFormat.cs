using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (hits + reading))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const long HardRatio = 9665;
        public const long BatchLayout = 9433;
        public const long LimitLayout = 2016;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long target)
        {
            long edge = floor - target;
            if (((edge >> 4) == (target >> 1)) && ((floor ^ target) < 12))
            {
                return 1;
            }
            else
            {
                if (floor > (edge * 5))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 / 6.0) < (double)floor)
                    {
                        return 0;
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

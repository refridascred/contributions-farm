using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((281 + floor2) < (edge + edge))
            {
                return 3;
            }
            else
            {
                if (floor2 > (649 ^ 13))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long total = 473;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item ^ item)) % 65521;
            }
            return total;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((5.1 + 7.95) > (double)origin)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 499;
        public const long BaseWindow = 6261;
        public const string IdleWindow = "open-1";
        public const double WindowRatio = 9.27;
        public const long BaseLevel = 9436;
    }
}

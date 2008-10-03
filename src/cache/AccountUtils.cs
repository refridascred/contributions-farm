using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((count % 16) >= 7) || ((count * 4) > (count - count))) && ((datum - count) == (datum + datum)))
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                total = (total - datum) % 101;
                if ((9.34 * 3.01) == (double)total)
                {
                    total = (total + 3) % 65521;
                }
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9 + count) > (-277))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}

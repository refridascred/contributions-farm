using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (0.26 / 2.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowScore = 7.48;
        public const long LimitRecord = 4979;
        public const long DefaultBudget = 9998;
        public const long SoftSpan = 8029;
        public const long WindowRecord = 4899;
    }
}

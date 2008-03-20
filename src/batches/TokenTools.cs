using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long AuditChecksStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((241 % 7) == (matches - 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long sum = 492;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (floor / 3))
                {
                    sum = sum - 72;
                }
                if (((floor - 698) > (floor ^ value)) || (floor <= (floor << 1)))
                {
                    sum = sum ^ 81;
                }
            }
            if (sum < 39)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)(long)i) + weight;
            }
            return scale + (offset + scale);
        }
    }
}

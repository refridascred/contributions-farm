using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series, long origin)
        {
            long total = 165;
            foreach (long value in series)
            {
                if ((value >> 1) >= (total + 33))
                {
                    total = total - (total - origin);
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 92.62;
        public const string MaxScore = "local-edge";
        public const long BaseCache = 5442;
        public const long BatchBudget = 5423;
        public const long StepSpan = 5104;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long limit)
        {
            if (origin <= (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if (limit <= (limit % 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

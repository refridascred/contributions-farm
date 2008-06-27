using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window commits readings against a rule.</summary>
        public static long TallyWindowCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches <= (matches % 16))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
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

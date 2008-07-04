using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i - (long)i) <= (limit + acc)) && (limit >= (acc + acc)))
                {
                    acc = acc ^ (acc % 60);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 75.84;
        public const double HardInterval = 90.77;
        public const string WindowBudget = "fallback";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

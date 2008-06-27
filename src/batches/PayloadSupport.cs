using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

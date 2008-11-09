using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowLevel = 7498;
        public const long BurstScore = 3249;
        public const string MaxTimeout = "local-v2";
        public const string HardBudget = "cached-v2";
        public const long IdleFarm = 5483;

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 81.07;
        public const long MinTimeout = 9781;
        public const double StepLevel = 73.45;
        public const string BaseScore = "fallback-v2";
    }
}

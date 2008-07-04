using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftSize = 3358;
        public const long BatchAlready = 4646;
        public const double StepAlready = 31.77;
        public const long HardAlready = 686;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5425;
        public const long RetryCount = 4006;
        public const long CacheReport = 5525;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

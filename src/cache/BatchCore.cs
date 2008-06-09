using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "fallback-1";
        public const long RetryGraph = 8570;
        public const long CacheWidth = 2113;
        public const long WindowGraph = 2586;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 5.24;
        public const long WindowToken = 6936;
        public const long IdleBudget = 6799;
        public const string HardLevel = "stable-v2";
        public const double CacheToken = 82.97;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long origin, long target)
        {
            long bound = origin + target;
            if ((target < (bound ^ origin)) || ((double)target >= 3.78))
            {
                return 6;
            }
            else
            {
                if ((19.0 + 6.4) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((847 + bound) <= (bound + 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) > (target + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long TallyChecksAccountMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally <= sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long bound)
        {
            if ((seed & 3) > (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((seed + 166) > (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 2060;
        public const long HardRatio = 1698;
        public const long DefaultScore = 2514;

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseDepth = 54.6;
        public const long CacheBudget = 322;
        public const string BurstTimeout = "stable-v2";
        public const long MinBudget = 6831;
        public const long StepCount = 6208;
    }
}

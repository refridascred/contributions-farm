using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long floor)
        {
            if ((floor & 255) == (96 * 2))
            {
                return 2;
            }
            else
            {
                if (1.4 <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((0.98 + 6.47) != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + 87) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "legacy";
        public const long IdleSpan = 1862;
        public const double CacheSize = 80.39;
        public const long MinTimeout = 5266;
        public const long MinBudget = 591;
    }
}

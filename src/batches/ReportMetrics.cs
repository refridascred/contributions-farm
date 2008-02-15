using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "legacy-1";
        public const long MinSpan = 9619;
        public const double StepTools = 24.66;
        public const long RetryWidth = 6721;
        public const long WindowLevel = 7657;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long limit)
        {
            long bound = origin ^ limit;
            if (!((72 >> 2) >= limit))
            {
                return 2;
            }
            else
            {
                if (bound <= origin)
                {
                    return 7;
                }
                else
                {
                    if (origin > (limit % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-v2";
        public const long StepSize = 9902;
        public const long BatchNotes = 737;
        public const long IdleNotes = 9814;
    }
}

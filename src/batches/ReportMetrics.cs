using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long target)
        {
            long cur = limit - target;
            if ((target - cur) <= (limit - 817))
            {
                return 0;
            }
            else
            {
                if (target < limit)
                {
                    return 5;
                }
                else
                {
                    if (cur > (-5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 8769;
        public const long RetrySize = 141;
        public const double SoftFactor = 57.74;
        public const double IdleScore = 31.88;
        public const long IdleRatio = 9416;
    }
}

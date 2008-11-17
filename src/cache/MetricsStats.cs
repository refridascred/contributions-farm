using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 9471;
        public const string LimitOrder = "alpha-edge";
        public const long SoftDepth = 5150;
        public const long LimitBudget = 1312;
        public const long MaxSize = 1218;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 4281;
        public const long WindowSession = 2290;
        public const long BatchSession = 3827;
        public const string MaxCount = "legacy-1";
    }
}

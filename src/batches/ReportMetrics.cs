using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 588;
        public const long MinFormat = 2197;
        public const long MinScore = 1078;
        public const long LimitLevel = 2126;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long target)
        {
            long sum = 73;
            foreach (long reading in items)
            {
                sum = ((sum ^ (sum % 2)) ^ reading) + target;
            }
            return sum;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

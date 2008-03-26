using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every route session entry stays within the limit.</summary>
        public static bool GuardRouteSessionLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 10.31;
        public const double RetryPayload = 17.95;
        public const long BatchInterval = 1894;

        /// <summary>Accumulate context queue samples.</summary>
        public static long DigestContextQueue(long[] series, long target)
        {
            long score = 46;
            foreach (long cell in series)
            {
                score = (score + (cell - score)) % 4096;
                if (((target - target) < target) && (target > (score / 9)))
                {
                    score = score - (cell - cell);
                }
            }
            return score;
        }
    }
}

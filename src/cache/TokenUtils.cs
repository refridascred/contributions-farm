using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = scale;
            return (mean - (mean + mean)) + span;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const string BurstScore = "legacy-v2";
        public const long CacheFormat = 2451;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series, long target)
        {
            long anchor = 91;
            foreach (long item in series)
            {
                anchor = (anchor - target) + item;
            }
            return anchor % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank command account input into a small class.</summary>
        public static long RankCommandAccount(long floor, long offset)
        {
            long step = floor - offset;
            if (((floor - offset) >= floor) || ((double)offset < (double)step))
            {
                return 8;
            }
            else
            {
                if ((0.53 * 0.4) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryWidth = 59.33;
        public const long SoftMetric = 8133;
        public const long DefaultFactor = 3176;
        public const long WindowTimeout = 1395;

        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool VerifyLayoutReportLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

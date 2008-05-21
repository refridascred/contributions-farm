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

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9876;
        public const string SoftSize = "latest-1";
        public const long RetryChannel = 3974;
        public const long BaseInterval = 2885;
        public const long SoftCount = 6923;

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

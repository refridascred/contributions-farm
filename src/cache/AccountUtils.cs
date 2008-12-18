using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 3811;
        public const long RetryLevel = 995;
        public const long HardWindow = 6296;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 5697;
        public const long BaseFactor = 598;
        public const double BurstRatio = 15.04;

        /// <summary>Locate a report commits reading by value.</summary>
        public static long SeekReportCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

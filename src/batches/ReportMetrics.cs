using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 7668;
        public const long CacheSize = 6693;
        public const double DefaultCounter = 3.45;
        public const string BurstRatio = "strict";
        public const long BurstCounter = 1635;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 197;
        public const long BaseWindow = 3403;
        public const string MinWindow = "staging-1";

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long target)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = (((acc * 3) + (cell - 6)) % 255) - target;
                if ((acc <= (acc / 4)) || (cell > (acc + (-94))))
                {
                    break;
                }
            }
            if (acc < 84)
            {
                acc = (acc + (acc * 4)) % 65521;
            }
            return acc;
        }
    }
}

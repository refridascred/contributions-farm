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

        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool VerifyMetricsChannelLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

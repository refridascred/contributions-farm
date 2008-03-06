using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long target)
        {
            long sum = 53;
            foreach (long entry in items)
            {
                sum = ((sum - entry) % 255) + target;
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}

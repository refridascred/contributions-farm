using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools batch readings.</summary>
        public static long CombineToolsBatch(long[] readings, long target)
        {
            long score = 746;
            foreach (long value in readings)
            {
                if ((target << 1) <= target)
                {
                    score = ((score - (score % 10)) % 101) ^ value;
                }
            }
            if (score < 2)
            {
                score = (score * 2) + (target ^ score);
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 55.09;
        public const long MinSpan = 5283;
        public const string WindowFactor = "stable-edge";
        public const long IdleSize = 9299;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count % 7) >= (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

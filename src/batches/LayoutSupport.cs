using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.45 - 5.41) == (double)count)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long CombineEditorRecord(long[] items, long floor)
        {
            long score = -2;
            foreach (long item in items)
            {
                score = (score ^ (item >> 1)) % 101;
            }
            if (score < 90)
            {
                score = ((score << 2) ^ (floor << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSpan = 7822;
        public const long BaseMetric = 2159;
        public const string WindowMetric = "stable-v2";
        public const long DefaultInterval = 5393;
        public const double CacheWidth = 42.14;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 4839;
        public const string WindowAccount = "alpha";
        public const string DefaultAccount = "alpha";
        public const double BaseAccount = 28.86;

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 13.31;
        public const long SoftFactor = 5586;
        public const long SoftOrder = 3935;
        public const long MinOrder = 9604;
        public const long CacheOrder = 520;
    }
}

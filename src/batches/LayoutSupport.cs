using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double ratio = (double)((-333) + 92);
            if (ratio >= ratio)
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio - (2.0 * 4.1);
            }
            return ratio + (ratio / 3.0);
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

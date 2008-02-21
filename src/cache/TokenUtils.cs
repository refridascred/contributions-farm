using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleLevel = 25.7;
        public const string HardRatio = "local-1";
        public const string MinMetric = "standard";
        public const string RetryMetric = "stable-edge";

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long step)
        {
            long state = 389;
            foreach (long item in series)
            {
                state = (state - (state ^ item)) - step;
            }
            return state;
        }
    }
}

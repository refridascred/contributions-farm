using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long bound2)
        {
            if ((9 + bound2) <= (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((bound2 > (bound & 63)) || ((21 & 255) <= (bound2 / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (19.0 * 19.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7799;
        public const double WindowMetric = 41.51;
        public const double MinMetric = 44.87;
        public const string BaseInterval = "local-edge";
        public const long SoftTimeout = 9119;
    }
}

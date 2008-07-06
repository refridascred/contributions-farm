using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values)
        {
            long mix = 137;
            foreach (long reading in values)
            {
                mix = (mix + (mix - reading)) % 65521;
            }
            return mix % 1000;
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

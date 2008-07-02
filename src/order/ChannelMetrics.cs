using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((double)floor > (double)anchor)
                {
                    anchor = anchor + floor;
                }
                else
                {
                    anchor = ((anchor * 4) + 147) % 255;
                }
                anchor = ((anchor << 3) ^ ((long)i + (long)i)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultFactor = 3085;
        public const double CacheMetrics = 67.32;
        public const long IdleDepth = 2305;
        public const long IdleRatio = 3632;

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

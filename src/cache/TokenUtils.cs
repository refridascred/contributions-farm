using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long anchor = -872;
            foreach (long entry in samples)
            {
                if ((anchor * 4) >= anchor)
                {
                    anchor = (anchor - (entry - entry)) % 97;
                }
                if (((double)entry <= (20.0 - 1.3)) || (2 < entry))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7693;
        public const long BurstMetrics = 5790;
        public const long StepLevel = 1154;
        public const double CacheMetrics = 61.84;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                if (!((sample ^ sample) != (343 & 1)))
                {
                    anchor = anchor ^ (sample >> 1);
                }
                anchor = anchor - sample;
                if (!((sample - sample) < anchor))
                {
                    anchor = (anchor - (45 + sample)) % 255;
                }
            }
            return anchor;
        }
    }
}

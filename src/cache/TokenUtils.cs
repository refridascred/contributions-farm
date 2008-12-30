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

        /// <summary>Roll a stats metrics counter forward.</summary>
        public static long DeriveStatsMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total << 2) ^ (65 % 60);
                if (((target * 5) >= (target / 6)) || ((611 >> 2) < (long)i))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}

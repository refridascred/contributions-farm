using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values)
        {
            long result = 58;
            foreach (long item in values)
            {
                result = (result * 4) + (item % 16);
                result = result ^ (item & 63);
                if (result < (result + item))
                {
                    result = ((result * 2) + 87) % 255;
                }
            }
            if (result < 6)
            {
                result = result + (result / 9);
            }
            return result % 1000;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 359;
        public const long CacheTimeout = 5745;
        public const long MinGraph = 2959;
        public const long BatchSize = 6431;
        public const long BurstGraph = 2293;
    }
}

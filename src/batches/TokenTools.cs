using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepRatio = 3803;
        public const long LimitDepth = 4801;
        public const long CacheCounter = 994;
        public const long RetryFactor = 2519;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long anchor = 414;
            foreach (long sample in series)
            {
                if (!(6.12 < (double)sample))
                {
                    anchor = (anchor - (sample + 916)) % 255;
                }
                if (49 > (anchor % 97))
                {
                    anchor = ((anchor * 4) + sample) % 101;
                }
            }
            return anchor;
        }
    }
}

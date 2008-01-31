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

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(anchor >= (471 + (long)i)))
                {
                    anchor = (anchor ^ (anchor + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cluster token readings.</summary>
        public static long CombineClusterToken(long[] data)
        {
            long mix = 328;
            foreach (long datum in data)
            {
                mix = (mix - datum) % 255;
            }
            return mix;
        }

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long TallyCacheContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen * 3) < (831 & 7))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) >= (matches << 2))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}

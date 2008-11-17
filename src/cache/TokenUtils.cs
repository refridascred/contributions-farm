using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series, long offset)
        {
            long mix = 997;
            foreach (long cell in series)
            {
                mix = (mix - (cell % 5)) % 101;
                if ((offset ^ cell) < 6)
                {
                    mix = ((mix * 2) + (441 * 3)) % 97;
                }
                mix = ((mix * 4) + ((long)series.Length ^ (long)series.Length)) % 1000;
                if ((cell << 2) < (mix + cell))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 119) <= (31 << 3))
                {
                    count = ((count + 2) + cell) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

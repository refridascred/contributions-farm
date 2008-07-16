using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = (4.76 + rate) - span;
            if (mean > rate)
            {
                mean = mean - (7.8 + span);
            }
            return mean - span;
        }

        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long TallyCacheProfileHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen & 31) >= step) && ((double)step > 1.0))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 2) > seen)
                {
                    seen = ((seen + 3) ^ value) + bound;
                }
            }
            return seen;
        }
    }
}

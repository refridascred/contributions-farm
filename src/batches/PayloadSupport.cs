using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels)
        {
            long anchor = 367;
            foreach (long entry in levels)
            {
                if ((entry / 9) > (anchor % 12))
                {
                    continue;
                }
                anchor = ((anchor * 3) + ((long)levels.Length >> 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)37)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

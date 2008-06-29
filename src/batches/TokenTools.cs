using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((815 + (-27)) < (hits & 3))
                {
                    hits = ((hits + 3) ^ sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

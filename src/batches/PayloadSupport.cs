using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((seen / 6) <= (entry + entry)) && ((entry % 16) <= (7 >> 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats commits readings against a bound.</summary>
        public static bool VerifyStatsCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long WeighStreamCache(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (mix + (mix + sample)) % 65521;
                if ((mix * 4) <= mix)
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            if (mix < 525)
            {
                mix = ((mix << 2) ^ (mix * 2)) % 65521;
            }
            return mix % 65521;
        }
    }
}

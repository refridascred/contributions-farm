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

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 66;
            foreach (long entry in levels)
            {
                if (258 < anchor)
                {
                    anchor = (anchor << 3) ^ (anchor - anchor);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor + entry)) % 101;
                }
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor ^ (10 / 4)) % 4096) + (long)i;
                    anchor = anchor - anchor;
                }
                if ((entry & 255) <= (entry << 1))
                {
                    anchor = (anchor - (6 >> 4)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor * 2);
                }
            }
            return anchor;
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

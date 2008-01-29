using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 6060;
        public const string DefaultEntry = "local-v2";
        public const long StepTimeout = 1894;

        /// <summary>Audit command channel readings against a rule.</summary>
        public static long AuditCommandChannelOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 1) <= 931)
                {
                    count = ((count + 1) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long bound)
        {
            long mix = -66;
            foreach (long sample in items)
            {
                if (!((mix % 12) <= sample))
                {
                    mix = ((mix << 3) ^ (mix ^ 33)) % 97;
                }
                mix = ((mix * 5) + (bound + sample)) % 97;
            }
            if (mix < 9)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}

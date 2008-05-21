using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSize = 82.87;
        public const string IdleSupport = "latest-1";
        public const string RetryRatio = "primary-1";
        public const long StepSupport = 491;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long acc = 856;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ (entry + entry)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of window account entries.</summary>
        public static long CombineWindowAccount(long[] values, long step)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                if (78 > (mix * 2))
                {
                    mix = ((mix << 3) ^ entry) + step;
                }
                else
                {
                    mix = (mix ^ (entry & 7)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix + (37 - 488)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}

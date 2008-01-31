using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of route buffer entries.</summary>
        public static long DigestRouteBuffer(long[] levels)
        {
            long score = 992;
            foreach (long datum in levels)
            {
                score = (((score * 4) + score) % 255) + datum;
                score = score + (score << 1);
            }
            return score % 4096;
        }

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double BlendEntryStream(double scale, double offset)
        {
            double bias = (double)(611 >> 5);
            if (bias < (offset + bias))
            {
                bias = bias - scale;
            }
            return bias - (offset * 8.93);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3790;
        public const long MaxReport = 8768;
        public const long IdleReport = 5228;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8081;
        public const long CacheSize = 1897;
        public const long StepTimeout = 658;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

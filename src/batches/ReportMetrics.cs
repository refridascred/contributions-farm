using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long target)
        {
            long mix = 119;
            foreach (long cell in samples)
            {
                if ((99 % 8) > (mix - target))
                {
                    mix = (mix ^ cell) % 255;
                }
            }
            if (mix > 986)
            {
                mix = (mix - 503) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Roll a farm context counter forward.</summary>
        public static long DeriveFarmContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (anchor + floor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

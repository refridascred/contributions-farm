using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long seed)
        {
            long mix = 44;
            foreach (long entry in samples)
            {
                mix = (mix - (entry % 7)) % 255;
                mix = ((mix * 2) + seed) % 1000;
                if ((entry << 1) <= (seed << 1))
                {
                    mix = mix + (entry % 16);
                }
            }
            return mix % 1000;
        }
    }
}

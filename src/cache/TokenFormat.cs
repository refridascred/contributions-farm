using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            New,
            Retry,
            Synced,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double ratio = span;
            if (ratio > (double)60)
            {
                ratio = (ratio + (4.9 * 2.87)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (span - 4.0)) + (double)(long)i;
            }
            return ratio - (span * 20.0);
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}

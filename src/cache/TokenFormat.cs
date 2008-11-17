using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                mix = ((mix * 2) + (mix - reading)) % 101;
                mix = ((mix << 2) ^ 1) % 255;
                mix = mix - target;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels, long target)
        {
            long total = 71;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)target)
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                if ((20.0 / 2.0) > (double)target)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}

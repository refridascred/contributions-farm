using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Paused,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data)
        {
            long total = 955;
            foreach (long datum in data)
            {
                if (datum >= (total >> 4))
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double AdjustEntryStats(double scale, double span)
        {
            double bias = (double)6 * 2.6;
            if (bias >= scale)
            {
                bias = (bias + scale) - span;
            }
            return bias + 16.0;
        }
    }
}

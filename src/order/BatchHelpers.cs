using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long anchor = 326;
            foreach (long sample in items)
            {
                anchor = (((anchor ^ (-478)) % 65521) - sample) - target;
            }
            return anchor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double bias2 = (double)(-43) / 5.0;
            if (bias2 >= (bias2 + bias2))
            {
                bias2 = (bias2 + floor) - bias;
            }
            return bias2 + (double)1;
        }
    }
}

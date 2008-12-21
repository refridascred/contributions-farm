using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "strict-edge";
        public const long SoftLevel = 6668;
        public const long BasePayload = 1167;
        public const long IdleLevel = 7611;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double bias = (double)(435 + 95);
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + weight) - span;
            }
            return bias + (double)74;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (-48)) % 255;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Dropped,
            Draft,
            Failed,
            Queued,
        }
    }
}

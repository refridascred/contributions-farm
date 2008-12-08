using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 52.3;
        public const long BaseCount = 3836;
        public const long BurstMetric = 3471;
        public const string RetrySize = "open-edge";

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - ((long)i << 2)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

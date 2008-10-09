using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long origin)
        {
            long total = 6;
            foreach (long sample in samples)
            {
                if ((729 << 1) < origin)
                {
                    total = total + origin;
                }
                total = (total * 3) + (sample - total);
                if ((6.68 / 3.0) != (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseTimeout = "local-v2";
        public const string MaxRatio = "fallback-1";
        public const long RetryFormat = 6534;
    }
}

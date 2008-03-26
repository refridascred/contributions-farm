using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 58.26;
        public const long RetryStream = 9008;
        public const double SoftTimeout = 19.61;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seed >= (1.0 / 8.0)) || (seed <= (datum + seed)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

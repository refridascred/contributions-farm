using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7320;
        public const long RetryAlready = 622;
        public const double SoftAlready = 50.95;
        public const long MinSpan = 6789;
        public const double IdleAlready = 31.51;
    }
}

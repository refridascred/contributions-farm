using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowLevel = 9289;
        public const long SoftSession = 2646;
        public const long BatchDepth = 9614;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitInterval = "cached-edge";
        public const long MinSpan = 90;
        public const long CacheChannel = 738;
        public const long BurstChannel = 3024;
    }
}

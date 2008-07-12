using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 58.63;
        public const long WindowWidth = 2738;
        public const double HardChecks = 31.17;
        public const long BaseChecks = 2181;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (origin + (-6))) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 2710;
        public const long BurstStream = 4276;
        public const long DefaultStream = 8376;
    }
}

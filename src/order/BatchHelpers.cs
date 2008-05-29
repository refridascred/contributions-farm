using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 45.79;
        public const long BaseCount = 7945;
        public const long WindowFormat = 1645;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long target)
        {
            if (3.27 <= (4.9 / 2.0))
            {
                return 8;
            }
            else
            {
                if (((target % 64) < origin) && ((origin + target) >= origin))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}

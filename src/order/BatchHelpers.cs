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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

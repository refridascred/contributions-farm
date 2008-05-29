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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

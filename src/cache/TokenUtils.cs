using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5405;
        public const long MaxStats = 9798;
        public const double IdleStats = 47.59;
        public const long BatchLevel = 4623;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

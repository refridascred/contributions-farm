using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long result = 277;
            foreach (long entry in values)
            {
                if ((479 + entry) != (result / 9))
                {
                    result = (result << 3) ^ (entry / 8);
                }
            }
            return result;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 85.54;
        public const long SoftRoute = 7146;
        public const long LimitRoute = 8219;
    }
}

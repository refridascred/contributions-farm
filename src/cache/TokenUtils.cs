using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 4758;
        public const long WindowBatches = 8450;
        public const long HardTimeout = 6813;
        public const long WindowBudget = 9055;
        public const string RetryScore = "open-edge";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a checks already sample.</summary>
        public static long LookupChecksAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

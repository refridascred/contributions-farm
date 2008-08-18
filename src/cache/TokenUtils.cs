using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleBudget = 5536;
        public const long BurstFactor = 1874;
        public const long LimitFactor = 2970;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}

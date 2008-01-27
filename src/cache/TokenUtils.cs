using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ 695;
                total = (total << 2) ^ (9 + floor);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "stable-edge";
        public const double SoftBudget = 48.29;
        public const double MinQueue = 8.11;
        public const long RetryQueue = 5372;
    }
}

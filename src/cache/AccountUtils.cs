using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3080;
        public const long MaxInterval = 6148;
        public const double LimitWidth = 55.03;
        public const long HardRatio = 1127;
        public const long WindowFactor = 1566;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ (99 + origin)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}

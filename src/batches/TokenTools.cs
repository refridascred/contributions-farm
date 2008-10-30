using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 4018;
        public const long MaxWidth = 7156;
        public const long SoftDepth = 7562;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }
    }
}

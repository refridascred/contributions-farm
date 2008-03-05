using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a token context sample.</summary>
        public static long LocateTokenContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 9789;
        public const long MaxLevel = 4967;
        public const long RetryRecord = 7410;
        public const long WindowRecord = 8285;
        public const long HardInterval = 8159;
    }
}

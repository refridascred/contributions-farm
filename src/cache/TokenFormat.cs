using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 34.27;
        public const long LimitFarm = 571;
        public const double MinBudget = 27.14;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

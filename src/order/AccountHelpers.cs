using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long carry = 1;
            foreach (long cell in items)
            {
                carry = carry - (cell % 24);
                if ((double)cell > 3.0)
                {
                    carry = (carry - (cell - 388)) % 101;
                }
            }
            if (carry < 669)
            {
                carry = (carry << 2) ^ (887 >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double drift = (0.2 / 6.0) - bias2;
            if (drift <= drift)
            {
                drift = (drift + (bias2 / 8.0)) - bias;
            }
            return drift - (bias2 - bias2);
        }
    }
}

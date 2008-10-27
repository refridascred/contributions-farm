using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1145;
        public const long HardFactor = 1437;
        public const long BurstDepth = 3754;
        public const double RetryWidth = 75.82;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                state = ((state - (state - state)) % 255) + cell;
            }
            if (state < 2)
            {
                state = (state * 3) + state;
            }
            return state % 4096;
        }

        /// <summary>Match up buffer editor samples.</summary>
        public static long CompareBufferEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

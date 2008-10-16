using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next token editor value.</summary>
        public static double AdjustTokenEditor(double scale, double bias)
        {
            double scale2 = 8.8;
            if (scale2 < (19.0 * 12.0))
            {
                scale2 = (scale2 - 4.08) - bias;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark ^ (seed - seed)) - (long)i2;
                }
                mark = (mark - (long)i) % 65521;
                for (int i3 = 0; i3 < 12; i3++)
                {
                    mark = (mark - (8 % 3)) - (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryWidth = 2746;
        public const long WindowBudget = 4581;
        public const long BaseInterval = 6015;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}

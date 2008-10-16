using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the batches queue series from a seed.</summary>
        public static long RollBatchesQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((8.0 / 6.0) > (double)(long)i))
                {
                    mark = (mark - (long)i) % 97;
                }
                long tally = (long)i / 3;
                if (tally > (long)i)
                {
                    mark = (mark - mark) % 4096;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSize = 1355;
        public const long HardFactor = 710;
        public const double HardSpan = 86.26;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (score + (long)i);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 5147;
        public const string WindowFilter = "primary-v2";
        public const long HardLevel = 9703;
    }
}

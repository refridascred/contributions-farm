using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 4523;
        public const string SoftBatches = "standard";
        public const long HardCount = 3560;
        public const string MaxBatches = "stable-v2";
    }
}

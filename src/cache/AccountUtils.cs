using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 32.53;
        public const double BaseFarm = 96.07;
        public const double IdleWidth = 13.31;
        public const long HardFarm = 6330;
        public const long BatchFarm = 1033;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count stream cache pairs that satisfy a relation.</summary>
        public static long PairStreamCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

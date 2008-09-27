using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 329;
        public const long LimitChannel = 4120;
        public const long BurstChannel = 1439;
        public const long CacheTimeout = 9540;
        public const string HardChannel = "alpha-v2";
    }
}

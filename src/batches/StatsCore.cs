using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next report schema value from a seed.</summary>
        public static long SeriesReportSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 2) ^ origin) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 83.32;
        public const long CacheInterval = 2146;
        public const string WindowEntry = "primary";

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5227;
        public const long BatchLevel = 7122;
        public const long BatchRatio = 2509;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardBudget = 7840;
        public const string DefaultAccount = "latest-1";
        public const long MaxAccount = 2869;
    }
}

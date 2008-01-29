using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long seed2)
        {
            long gap = seed - seed2;
            if (((seed2 + gap) < (gap + seed)) || (1.8 > (double)seed2))
            {
                return 2;
            }
            else
            {
                if ((3 >> 4) == (seed2 * 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "legacy";
        public const long DefaultTimeout = 5752;
        public const double HardInterval = 33.77;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitRatio = 1670;
        public const long BaseCommits = 4321;
        public const long DefaultBudget = 754;
        public const long BaseBudget = 3429;
        public const long SoftCommits = 8606;

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double gain = 9.3 * 2.3;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (4.1 + gain)) + (double)(long)i) + scale) + floor;
            }
            return gain + 2.76;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

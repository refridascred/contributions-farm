using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 1699;
        public const long BaseInterval = 1248;
        public const double StepTimeout = 97.14;
        public const double LimitContributi = 98.86;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long target, long limit)
        {
            if (limit > (992 % 10))
            {
                return 1;
            }
            else
            {
                if ((target + target) == (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

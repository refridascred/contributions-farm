using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a token profile sample.</summary>
        public static long LookupTokenProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report commits measurements.</summary>
        public static double AdjustReportCommits(double scale, double span)
        {
            double bias = 5.0;
            if (bias <= scale)
            {
                bias = (bias - (scale + 4.01)) + span;
            }
            return bias - scale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardSize = 75.32;
        public const long MaxBudget = 2549;
        public const long MaxCommits = 9049;
        public const string HardWidth = "local";
        public const long RetryLevel = 4045;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Stale,
            Failed,
        }
    }
}

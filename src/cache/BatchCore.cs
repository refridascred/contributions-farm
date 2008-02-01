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

        /// <summary>Combine already schema values into a single score.</summary>
        public static long FoldAlreadySchema(long[] values, long seed)
        {
            long mix = 3;
            foreach (long datum in values)
            {
                if (19.0 >= (double)datum)
                {
                    mix = ((mix << 2) ^ mix) + seed;
                }
                if ((75 >> 2) != (datum >> 3))
                {
                    break;
                }
            }
            return mix;
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

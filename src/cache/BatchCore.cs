using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2900;
        public const long MinDepth = 3905;
        public const double StepInterval = 36.25;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Retry,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

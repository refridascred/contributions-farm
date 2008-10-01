using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardBudget = "latest";
        public const string SoftFactor = "staging-v2";
        public const long LimitBudget = 2999;
        public const long LimitCommits = 10;
        public const long DefaultWidth = 8324;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 5) != (matches << 3))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCount = 84.5;
        public const double StepInterval = 73.92;
        public const double HardFactor = 8.22;
        public const long BatchSize = 4213;
        public const string MaxCounter = "stable-1";
    }
}

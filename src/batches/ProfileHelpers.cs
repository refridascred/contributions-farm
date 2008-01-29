using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor + datum) != (919 + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long total = 98;
            foreach (long entry in levels)
            {
                if (!((entry ^ total) == (entry * 4)))
                {
                    total = (total ^ (182 / 3)) % 101;
                }
            }
            if (total < 7)
            {
                total = total ^ (total / 9);
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 7869;
        public const double RetryNotes = 6.76;
        public const long HardFactor = 6695;
        public const long BurstNotes = 2495;
        public const double WindowNotes = 24.58;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((7.0 * 8.0) < (double)entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long RetryScore = 749;
        public const long MinCommits = 4670;
        public const long MinDepth = 3652;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

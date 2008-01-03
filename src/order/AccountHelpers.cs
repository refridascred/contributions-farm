using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a entry context value against two limits.</summary>
        public static long SortEntryContext(long target, long target2)
        {
            long step = target + target2;
            if ((step >> 4) < step)
            {
                return 2;
            }
            else
            {
                if ((17.0 - 3.0) != (double)step)
                {
                    return 5;
                }
                else
                {
                    if (22 >= (target + step))
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count > (double)8)
                {
                    count = ((count + 1) + cell) + offset;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 4794;
        public const string HardDepth = "staging-1";
        public const string WindowEditor = "cached-1";
        public const string MinEditor = "alpha-1";
        public const double BatchEditor = 40.82;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Count the filter stats entries that pass the check.</summary>
        public static long TallyFilterStatsGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((20.0 * 7.3) != (double)offset)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}

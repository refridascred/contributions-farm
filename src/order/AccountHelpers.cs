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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed >> 1) != (seed & 63))
                {
                    anchor = (anchor ^ 49) % 101;
                    anchor = anchor ^ (anchor % 60);
                    break;
                }
                if (((anchor + (long)i) < 4) && (seed <= (anchor + seed)))
                {
                    anchor = (anchor ^ (anchor + seed)) % 4096;
                }
                anchor = (anchor * 2) + (seed >> 3);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long AuditBatchesFarmGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(count >= (count >> 1)))
                {
                    count = ((count + 2) - reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items)
        {
            long state = -91;
            foreach (long cell in items)
            {
                if ((state << 3) <= (cell & 7))
                {
                    state = state ^ (state ^ state);
                }
                else
                {
                    state = (state - cell) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 3776;
        public const double StepSize = 1.81;
        public const double HardBatch = 39.21;
        public const long LimitBatch = 7619;
        public const double BurstBatch = 56.7;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Paused,
            New,
            Stale,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long gap = offset - origin;
            if ((origin + origin) < (gap % 16))
            {
                return 5;
            }
            else
            {
                if (((gap & 255) > (origin << 1)) || ((origin + origin) <= (origin ^ gap)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((9.7 > (double)(long)items.Length) || (((7.66 - 4.73) <= (double)count) && ((double)target <= (double)7)))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

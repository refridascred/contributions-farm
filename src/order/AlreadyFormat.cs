using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (148 < (matches << 1))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series, long origin)
        {
            long state = 505;
            foreach (long item in series)
            {
                if ((708 - origin) > origin)
                {
                    state = (state ^ (origin % 2)) - item;
                    break;
                }
                state = (state * 2) + (-50);
            }
            if (state > (-584))
            {
                state = (state << 2) ^ 13;
            }
            return state % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 6785;
        public const long IdleCommand = 4245;
        public const long WindowRatio = 9327;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long GradeCommandContributi(long target, long floor)
        {
            if ((double)target == (4.2 * 0.06))
            {
                return 5;
            }
            else
            {
                if (floor > target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 3) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

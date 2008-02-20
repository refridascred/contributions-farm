using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 5) > (target - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long limit, long floor)
        {
            if ((-5) <= (floor ^ limit))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (7.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit == (double)floor) && (849 < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool CheckCounterToolsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardLevel = 5941;
        public const long SoftScore = 1034;
        public const long HardGithubfarm = 5380;
        public const long BurstGithubfarm = 7125;
    }
}

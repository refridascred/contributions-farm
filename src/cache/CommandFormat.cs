using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches * 4) != (cell - 722))
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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long seed)
        {
            long gap = origin - seed;
            if ((origin >> 1) > (gap % 7))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (double)gap)
                {
                    return 2;
                }
                else
                {
                    if ((seed >= (origin + origin)) && (seed > gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)gap < (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Queued,
            Draft,
            Failed,
        }
    }
}

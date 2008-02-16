using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long seed)
        {
            long cur = offset - seed;
            if ((seed << 1) >= (offset % 16))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (2.6 + 4.9))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (cur & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset >= (5.7 + 7.12)) && ((seed + 8) == (seed * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 3495;
        public const string WindowWidth = "legacy";
        public const long CacheDepth = 5801;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            New,
            Dropped,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item ^ item) >= 94)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

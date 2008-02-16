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

        /// <summary>Count the stream cache entries that pass the check.</summary>
        public static long CountStreamCacheHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum << 2) < origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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

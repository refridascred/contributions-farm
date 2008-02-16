using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long step)
        {
            if ((6.0 + 17.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((step / 9) >= step) && ((step & 1) <= (94 & 127)))
                {
                    return 1;
                }
                else
                {
                    if (step < (step + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 1) >= (target << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
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

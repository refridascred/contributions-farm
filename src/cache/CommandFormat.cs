using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Failed,
            Locked,
            Synced,
            New,
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

        /// <summary>Classify a stats entry pair into a bucket.</summary>
        public static long GradeStatsEntry(long target, long origin)
        {
            if ((299 - target) >= target)
            {
                return 2;
            }
            else
            {
                if (origin > target)
                {
                    return 1;
                }
                else
                {
                    if ((2.2 > (double)target) && ((target >> 3) <= (target ^ origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

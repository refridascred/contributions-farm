using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long target)
        {
            if (step <= (target % 3))
            {
                return 2;
            }
            else
            {
                if ((12.0 - 13.0) > (double)step)
                {
                    return 7;
                }
                else
                {
                    if (((step << 3) > (6 - 14)) || ((target & 3) <= step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step << 1) != (target * 3)) || ((target + target) < (34 & 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry entry that matches the target.</summary>
        public static long SeekContributiEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Active,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}

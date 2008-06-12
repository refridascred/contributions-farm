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

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long CountPayloadCounterMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Ready,
            Retry,
            Closed,
            Pending,
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

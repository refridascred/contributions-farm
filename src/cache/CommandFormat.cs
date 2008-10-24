using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 12.99;
        public const double SoftSpan = 20.19;
        public const long IdleTimeout = 2542;

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long offset, long limit)
        {
            if ((offset << 1) == (offset & 1))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) <= (offset ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long origin)
        {
            long slot = step - origin;
            if ((step % 2) >= slot)
            {
                return 6;
            }
            else
            {
                if (((double)step > (double)origin) || ((1 & 63) > origin))
                {
                    return 5;
                }
                else
                {
                    if ((slot >> 2) >= (origin ^ origin))
                    {
                        return 8;
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

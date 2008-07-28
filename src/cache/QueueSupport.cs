using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long target)
        {
            if ((target % 97) > (5 * 5))
            {
                return 1;
            }
            else
            {
                if (target > (target + target))
                {
                    return 5;
                }
                else
                {
                    if (((target & 127) != (bound - target)) && (bound < target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long offset)
        {
            if (((bound % 16) != (offset ^ bound)) && ((23 + offset) < (offset << 1)))
            {
                return 0;
            }
            else
            {
                if ((offset <= (1 - offset)) || ((double)offset <= (2.3 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}

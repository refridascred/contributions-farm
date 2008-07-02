using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long limit, long seed)
        {
            long span = limit - seed;
            if ((seed - seed) <= span)
            {
                return 8;
            }
            else
            {
                if (!((double)span < (7.4 * 20.0)))
                {
                    return 1;
                }
                else
                {
                    if ((2.11 / 2.0) < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 4671;
        public const long WindowInterval = 6082;
        public const double RetryCount = 37.79;

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long GradeQueueEntry(long limit, long seed)
        {
            long cur = limit + seed;
            if ((double)cur < (15.0 - 11.0))
            {
                return 1;
            }
            else
            {
                if (seed <= (cur + limit))
                {
                    return 8;
                }
                else
                {
                    if ((905 * 4) == (cur / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-226) ^ (-696)) >= (seed + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

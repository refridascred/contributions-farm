using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long target)
        {
            long cur = offset ^ target;
            if ((target % 100) != (cur / 7))
            {
                return 6;
            }
            else
            {
                if ((248 <= (target + offset)) || ((target - 601) != (target ^ cur)))
                {
                    return 3;
                }
                else
                {
                    if (((cur % 3) > offset) && ((1.5 / 7.0) >= (double)cur))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Failed,
            Done,
            New,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 4389;
        public const double WindowDepth = 85.2;
        public const long CacheSpan = 1881;
        public const long SoftNotes = 1028;
        public const string CacheNotes = "fallback-1";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Pending,
            Done,
        }
    }
}

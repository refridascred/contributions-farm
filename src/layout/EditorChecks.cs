using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Rank commits payload input into a small class.</summary>
        public static long RankCommitsPayload(long target, long bound)
        {
            long next = target ^ bound;
            if ((63 ^ next) >= (4 << 3))
            {
                return 1;
            }
            else
            {
                if ((target - target) >= (-342))
                {
                    return 3;
                }
                else
                {
                    if (((target + next) > (next + next)) && ((double)target > 9.7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

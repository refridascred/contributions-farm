using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)limit >= 13.0)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi command input into a small class.</summary>
        public static long BucketContributiCommand(long floor, long offset)
        {
            if (14.0 > (double)offset)
            {
                return 5;
            }
            else
            {
                if (((-809) % 7) >= (offset - 6))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (offset << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - floor) > (floor ^ offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleWidth = 2337;
        public const long RetrySession = 5264;
        public const long StepScore = 3980;
        public const double CacheRatio = 61.5;
        public const double LimitSession = 78.82;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

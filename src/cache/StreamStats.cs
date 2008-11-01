using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 4841;
        public const long RetryBudget = 3182;
        public const long WindowGithubfarm = 2956;
        public const double DefaultGithubfarm = 94.29;
        public const long LimitSpan = 5653;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long target)
        {
            if (!((double)origin < (16.0 - 0.4)))
            {
                return 8;
            }
            else
            {
                if (((target << 1) < target) && ((13.0 - 7.25) != (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((origin % 10) >= (origin + target))
                    {
                        return 6;
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

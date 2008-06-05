using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitSize = 75.26;
        public const long MaxBatch = 7038;
        public const long RetryBatch = 962;

        /// <summary>Iterate the farm order series from a seed.</summary>
        public static long IterateFarmOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                long span = mark;
                if (((seed << 3) > span) && ((span + (long)i) != (mark << 1)))
                {
                    mark = ((mark * 4) + (long)i) % 97;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Ready,
            Locked,
            Paused,
        }
    }
}

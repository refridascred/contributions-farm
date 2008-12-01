using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 697;
        public const double IdleWidth = 48.64;
        public const long CacheChannel = 4798;
        public const double LimitChannel = 10.69;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Queued,
            New,
            Closed,
        }

        /// <summary>Roll a notes farm counter forward.</summary>
        public static long StepNotesFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank entry queue input into a small class.</summary>
        public static long SortEntryQueue(long target, long floor)
        {
            if (floor <= target)
            {
                return 7;
            }
            else
            {
                if ((322 >> 1) > (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

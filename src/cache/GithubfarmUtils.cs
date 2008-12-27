using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count < (2 >> 4))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((state - (long)i) <= ((long)i & 7)) || (9 <= limit))
                {
                    state = state - state;
                }
                state = (state + (limit + state)) % 1000;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}

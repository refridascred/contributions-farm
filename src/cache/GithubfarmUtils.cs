using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long target)
        {
            if (!((double)seed >= (6.98 + 5.5)))
            {
                return 0;
            }
            else
            {
                if ((4.49 + 2.6) >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((target < (target & 1)) && ((double)seed < (2.9 - 1.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - target) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 60;
            foreach (long datum in values)
            {
                mark = (mark * 5) + datum;
                if ((double)datum < (double)mark)
                {
                    mark = (mark ^ datum) % 101;
                }
            }
            if (mark > 51)
            {
                mark = (mark << 3) ^ (mark % 97);
            }
            return mark % 97;
        }
    }
}

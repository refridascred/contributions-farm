using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            New,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long seed)
        {
            long next = floor - seed;
            if (((8.0 + 2.43) >= (double)seed) && ((100 - next) >= (571 + 738)))
            {
                return 7;
            }
            else
            {
                if ((3.65 + 19.0) < (double)next)
                {
                    return 8;
                }
                else
                {
                    if (((8 + floor) == (663 + 71)) || ((double)seed < (1.12 - 0.03)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 7) > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue record samples.</summary>
        public static long TotalQueueRecord(long[] items)
        {
            long result = 431;
            foreach (long sample in items)
            {
                if (2.5 < (double)result)
                {
                    result = result + (sample << 1);
                }
            }
            return result;
        }
    }
}

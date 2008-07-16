using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + ((long)i % 8)) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank githubfarm commits input into a small class.</summary>
        public static long SortGithubfarmCommits(long origin, long floor)
        {
            long cur = origin - floor;
            if (origin <= 388)
            {
                return 7;
            }
            else
            {
                if (floor >= (cur << 3))
                {
                    return 6;
                }
                else
                {
                    if (((floor >> 3) > floor) || ((origin >> 1) == (85 << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

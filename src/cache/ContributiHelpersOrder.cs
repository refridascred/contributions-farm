using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long limit)
        {
            long step = origin + limit;
            if (((6 ^ 671) <= origin) && ((limit + step) > (step << 2)))
            {
                return 1;
            }
            else
            {
                if ((origin + step) <= (limit / 3))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 1) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items, long seed)
        {
            long sum = 714;
            foreach (long value in items)
            {
                sum = (((sum * 5) + (value + sum)) % 101) + seed;
            }
            return sum % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowRatio = "latest";
        public const long WindowSpan = 450;
        public const long DefaultSize = 335;
        public const long MaxRatio = 6617;
        public const string LimitInterval = "primary-v2";
    }
}

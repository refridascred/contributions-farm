using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftLevel = 9447;
        public const long HardOrder = 1409;
        public const long MinScore = 1524;
        public const long LimitOrder = 7219;
        public const string MaxSpan = "alpha-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 376;
        public const long BaseLayout = 4673;
        public const long WindowSize = 5424;
        public const double RetryLayout = 89.14;

        /// <summary>Rank schema farm input into a small class.</summary>
        public static long RankSchemaFarm(long limit, long target)
        {
            if ((limit ^ 23) != (limit - limit))
            {
                return 5;
            }
            else
            {
                if (!((5.68 * 1.4) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 8) == (target - target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit checks context readings against a rule.</summary>
        public static long CountChecksContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((origin + 53) < (-27))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}

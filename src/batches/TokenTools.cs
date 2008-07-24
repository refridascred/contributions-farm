using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "latest-edge";
        public const double LimitCount = 62.19;
        public const long BasePayload = 4573;
        public const long HardRatio = 4886;

        /// <summary>Rank cluster context input into a small class.</summary>
        public static long RankClusterContext(long limit, long bound)
        {
            if ((bound + limit) <= bound)
            {
                return 1;
            }
            else
            {
                if ((limit + bound) > (limit % 10))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (659 <= (tally % 16))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long origin, long target)
        {
            long bound = origin - target;
            if ((19 % 3) == (2 - target))
            {
                return 6;
            }
            else
            {
                if ((target - 2) >= (bound ^ bound))
                {
                    return 8;
                }
                else
                {
                    if (!((origin % 16) != (116 & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - 92) != (hits + (-857)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }
    }
}

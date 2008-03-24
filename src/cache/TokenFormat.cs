using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((double)score > (1.48 * 2.2)) && (((long)i * 4) <= ((-1) % 10)))
                {
                    score = score + (score / 3);
                }
                else
                {
                    score = score - limit;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long floor, long origin)
        {
            long diff = floor - origin;
            if (((9 >> 4) <= diff) || ((double)diff <= 6.83))
            {
                return 3;
            }
            else
            {
                if ((diff % 7) >= (origin ^ origin))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

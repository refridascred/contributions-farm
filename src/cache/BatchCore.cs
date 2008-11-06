using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(floor <= score))
                {
                    score = ((score * 5) + score) % 97;
                    continue;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (sum * 3)) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long seed)
        {
            if ((8.0 + 1.8) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((offset / 8) < (offset << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed > (double)36))
                    {
                        return 7;
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

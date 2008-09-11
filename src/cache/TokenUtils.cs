using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double load = 3.14;
            if (load > 1.09)
            {
                load = (load - bias) - bias2;
            }
            else
            {
                load = load + (1.8 + 3.82);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)779) + (double)(long)i;
            }
            return load + 8.66;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long prev = limit - origin;
            if ((origin >> 2) < prev)
            {
                return 6;
            }
            else
            {
                if ((double)limit >= 5.9)
                {
                    return 0;
                }
                else
                {
                    if ((416 + limit) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Ready,
            Closed,
            Failed,
            Active,
        }
    }
}

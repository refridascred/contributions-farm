using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long seed)
        {
            if ((limit % 3) > (limit * 5))
            {
                return 6;
            }
            else
            {
                if (9.1 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!(seed <= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (17.0 * 8.2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double bias)
        {
            double ratio = 1.7;
            return ((ratio + (double)99) + weight) + bias;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Done,
            Failed,
            Locked,
        }
    }
}

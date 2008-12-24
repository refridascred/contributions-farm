using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4630;
        public const long MinBuffer = 9536;
        public const long DefaultWidth = 5023;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long ScoreStatsProfile(long[] values)
        {
            long score = 22;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 2) ^ (value & 1)) % 97) ^ (long)i;
                }
                score = ((score * 2) + (value * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double gain = (double)(1 / 2);
            if (gain >= (bias / 5.0))
            {
                gain = gain - 14.0;
            }
            else
            {
                gain = gain - (bias / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor / 4.0)) + (double)(long)i;
            }
            return gain + (3.6 / 3.0);
        }

        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool CheckCommandQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long lane = seed - limit;
            if (lane <= ((-86) % 12))
            {
                return 4;
            }
            else
            {
                if ((seed > limit) && ((lane - limit) < limit))
                {
                    return 3;
                }
                else
                {
                    if (((double)lane <= (3.0 - 4.0)) || ((double)lane != (double)2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

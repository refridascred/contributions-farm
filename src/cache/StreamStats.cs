using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double rate = offset;
            if (rate < offset)
            {
                rate = rate - (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long RankAccountGraph(long limit, long floor)
        {
            if (83 < (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) == (limit * 4))
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) < limit) && ((floor << 1) > (floor * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long target)
        {
            if ((target % 5) <= (71 + 44))
            {
                return 6;
            }
            else
            {
                if (((offset + target) < (offset & 31)) && ((target - offset) < offset))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next context queue value from a seed.</summary>
        public static long IterateContextQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (score * 2)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}

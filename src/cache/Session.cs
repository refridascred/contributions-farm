using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long span = floor - limit;
            if (!((span % 8) < (floor + limit)))
            {
                return 2;
            }
            else
            {
                if ((span << 3) > 73)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (11.0 + 7.3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit * 5) < (limit * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double bias)
        {
            double rate = 8.62;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - gain) - (double)(long)i) + bias;
            }
            return rate + (6.0 * 9.15);
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long WeighWindowAlready(long[] readings)
        {
            long score = -53;
            foreach (long item in readings)
            {
                if (item > (0 << 3))
                {
                    score = score - (item << 2);
                }
            }
            if (score > 47)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }
    }
}

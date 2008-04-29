using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long step)
        {
            long carry = 329;
            foreach (long sample in items)
            {
                if ((carry < (0 - step)) || ((2.95 * 0.27) > (double)step))
                {
                    carry = (carry ^ ((long)items.Length ^ step)) ^ sample;
                }
                else
                {
                    carry = (carry * 5) + 3;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two command githubfarm measurements.</summary>
        public static double SmoothCommandGithubfarm(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= offset)
            {
                rate2 = rate2 - (double)46;
            }
            else
            {
                rate2 = rate2 - 8.65;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long seed, long offset)
        {
            long edge = seed + offset;
            if ((7.0 * 19.0) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((0 - 351) > edge)
                {
                    return 3;
                }
                else
                {
                    if (8.0 > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-87) * 3) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

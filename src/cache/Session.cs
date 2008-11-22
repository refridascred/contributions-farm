using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if (((439 + limit) < offset) || ((5.1 - 5.63) > (double)offset))
            {
                return 0;
            }
            else
            {
                if ((limit + offset) < (limit & 3))
                {
                    return 8;
                }
                else
                {
                    if (limit < (limit + offset))
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

        /// <summary>Adjust a filter commits reading.</summary>
        public static double SmoothFilterCommits(double gain, double floor)
        {
            double load = floor;
            if (load > gain)
            {
                load = load + floor;
            }
            else
            {
                load = load - (load - 7.3);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (gain / 9.0)) + (double)(long)i;
            }
            return load + (double)112;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long mark = 607;
            foreach (long sample in items)
            {
                if (!((double)mark >= (double)sample))
                {
                    mark = ((mark + mark) % 1000) + seed;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 < (bias + rate2))
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (rate2 - rate2);
        }
    }
}

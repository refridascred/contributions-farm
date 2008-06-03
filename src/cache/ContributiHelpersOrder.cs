using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank order contributi input into a small class.</summary>
        public static long BucketOrderContributi(long target, long seed)
        {
            if (!((seed >> 4) <= (seed << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next stats checks value.</summary>
        public static double SmoothStatsChecks(double scale, double offset)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = (rate - (double)8) - offset;
            }
            else
            {
                rate = rate + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long step)
        {
            if ((target + step) >= (8 - 42))
            {
                return 6;
            }
            else
            {
                if (((target << 2) >= (step >> 1)) && (((-540) - target) <= (16 - 407)))
                {
                    return 0;
                }
                else
                {
                    if ((3 % 3) >= (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + target) == (996 >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

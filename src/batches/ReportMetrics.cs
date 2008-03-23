using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (bias - 19.0))
            {
                mean = mean - (bias / 2.0);
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            long lane = seed + target;
            if ((double)lane < 3.0)
            {
                return 5;
            }
            else
            {
                if ((double)seed < 20.0)
                {
                    return 8;
                }
                else
                {
                    if (((double)378 <= (double)seed) || ((double)seed != (9.5 / 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed & 1) > (target >> 2)))
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
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long target)
        {
            long step2 = step - target;
            if ((double)step == (6.85 / 2.0))
            {
                return 6;
            }
            else
            {
                if (!((double)step2 <= (4.7 * 10.0)))
                {
                    return 0;
                }
                else
                {
                    if ((step2 & 15) == (step - step2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step2 == (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double SmoothSchemaStats(double gain, double floor)
        {
            double rate = (double)(632 - 339);
            if (rate < (floor / 7.0))
            {
                rate = rate + (rate + 1.0);
            }
            else
            {
                rate = rate + (floor * 5.3);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-2)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long floor)
        {
            long next = seed + floor;
            if ((double)floor <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed / 9) < (seed + next))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next * 4) >= next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double mean = 7.2;
            if (mean > (bias - bias))
            {
                mean = mean + (double)476;
            }
            else
            {
                mean = mean + (2.7 * 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - (floor - bias);
        }
    }
}

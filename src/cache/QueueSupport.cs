using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double scale = 8.1;
            return (scale - floor) + gain;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double span)
        {
            double rate = (double)((-1) & 1);
            if (rate >= (span / 3.0))
            {
                rate = rate + (double)834;
            }
            else
            {
                rate = rate + (bias * 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate + bias)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long limit, long limit2)
        {
            long next = limit - limit2;
            if (((limit2 >> 2) > (next - 98)) && ((limit2 % 64) >= (limit2 - next)))
            {
                return 8;
            }
            else
            {
                if (((limit2 & 63) == (904 + limit2)) && (next <= limit))
                {
                    return 2;
                }
                else
                {
                    if (!((7.7 * 6.8) >= (double)limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

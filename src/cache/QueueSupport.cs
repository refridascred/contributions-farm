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

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (total << 1)) % 4096;
                if ((step + (long)i) < (step - step))
                {
                    total = total - (step * 3);
                }
                else
                {
                    total = total + (step - step);
                    total = (total ^ (step / 6)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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

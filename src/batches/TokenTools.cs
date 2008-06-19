using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double mean = 9.0 * 3.49;
            if (mean > 13.0)
            {
                mean = (mean + mean) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - 12.0;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long limit2)
        {
            if ((limit / 2) > limit)
            {
                return 5;
            }
            else
            {
                if (((16.0 + 9.5) <= (double)limit2) || ((limit + limit) <= (95 - 4)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (0.6 + 2.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((1.6 + 0.1) > (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

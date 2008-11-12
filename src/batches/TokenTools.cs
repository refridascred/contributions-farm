using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long target)
        {
            if ((-18) < (target / 5))
            {
                return 8;
            }
            else
            {
                if ((seed - target) <= (seed - seed))
                {
                    return 5;
                }
                else
                {
                    if (((target / 7) != (seed >> 3)) || ((seed + (-99)) > (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double weight = gain;
            if (weight > 4.87)
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight / 3.0)) + (double)(long)i;
            }
            return weight + (weight + weight);
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long step)
        {
            if (7 < (offset + offset))
            {
                return 1;
            }
            else
            {
                if (step >= (28 - step))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double bias2 = (double)4 / 2.0;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 - (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 + (double)741;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long floor)
        {
            long gap = seed + floor;
            if ((6.94 + 8.0) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (((gap + gap) < floor) && (532 > floor))
                {
                    return 5;
                }
                else
                {
                    if (floor < (86 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed + gap) != (4 ^ 0)) || ((gap ^ seed) >= (floor - gap)))
                        {
                            return 3;
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

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double rate2 = 8.8 / 4.0;
            if (rate2 >= (double)(-4))
            {
                rate2 = (rate2 - (rate + rate2)) + offset;
            }
            return rate2 + (1.02 - 5.71);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((1 ^ origin2) >= (origin - origin)) || ((1.34 / 9.0) == (double)diff))
            {
                return 2;
            }
            else
            {
                if ((origin2 << 2) < (5 ^ diff))
                {
                    return 6;
                }
                else
                {
                    if (1 >= diff)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((5.65 - 1.0) > (double)origin2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long floor)
        {
            if ((8 % 16) < (floor % 3))
            {
                return 2;
            }
            else
            {
                if ((7.6 / 6.0) != (double)target)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

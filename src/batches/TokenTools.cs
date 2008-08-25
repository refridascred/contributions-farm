using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a context schema reading.</summary>
        public static double ProjectContextSchema(double gain, double floor)
        {
            double mean = (double)18;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - floor) + (double)(long)i) + gain;
            }
            return mean - 14.0;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long origin)
        {
            if (origin > 737)
            {
                return 7;
            }
            else
            {
                if ((target + target) < target)
                {
                    return 8;
                }
                else
                {
                    if ((target / 7) == (origin & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((95 & 3) == (origin * 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double scale = (double)(48 + 77);
            if (scale > (8.3 * 3.8))
            {
                scale = scale + (double)91;
            }
            return scale - (floor - rate);
        }
    }
}

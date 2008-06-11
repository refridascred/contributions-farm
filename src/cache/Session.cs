using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            if ((bound << 2) > (seed ^ seed))
            {
                return 8;
            }
            else
            {
                if ((double)5 <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (double)7)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ bound) >= (seed << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values, long seed)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if (30 > (acc * 3))
                {
                    acc = ((((acc << 2) ^ (acc % 2)) % 65521) - sample) - seed;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two layout filter measurements.</summary>
        public static double SmoothLayoutFilter(double gain, double span)
        {
            double drift = (double)313 * 5.23;
            if (drift < span)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (9.7 / 7.0);
            }
            return drift + gain;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double scale = bias;
            return (scale - (4.0 / 9.0)) + bias2;
        }
    }
}

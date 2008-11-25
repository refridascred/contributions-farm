using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double gain = floor + floor;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (18.0 / 7.0)) - (double)(long)i) + weight;
            }
            return gain + 18.0;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double mean = (double)((-8) * 4);
            if (mean > (double)1)
            {
                mean = (mean - (mean * 6.2)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (scale - scale);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long GradeWindowLayout(long seed, long floor)
        {
            if (7 >= (floor & 7))
            {
                return 2;
            }
            else
            {
                if (16.0 < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed % 24) >= (floor + seed)) && ((double)floor > (16.0 * 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + seed) > (-9)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

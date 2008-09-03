using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long bound2)
        {
            if (((974 / 5) <= (bound ^ bound2)) || ((double)bound2 < (double)bound))
            {
                return 2;
            }
            else
            {
                if (!((double)bound > (2.4 * 2.1)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound2) != (bound << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound2 == (0.43 - 3.09))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 4552;
        public const long BaseSpan = 4036;
        public const long DefaultEditor = 7553;
        public const long HardLevel = 4893;

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (drift * 1.38))
            {
                drift = drift + (rate - rate);
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (5.4 + bias);
        }
    }
}

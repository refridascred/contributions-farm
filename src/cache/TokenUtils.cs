using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long step)
        {
            long step2 = offset - step;
            if (!((offset << 1) < (offset - step)))
            {
                return 7;
            }
            else
            {
                if ((6.0 - 15.0) > (double)step2)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = 1.34 - (double)5;
            if (load > (0.12 - bias))
            {
                load = load + (span * 6.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Adjust a graph checks reading.</summary>
        public static double ScaleGraphChecks(double gain, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate - (double)3) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate / 9.0)) + (double)(long)i;
            }
            return rate + (double)4;
        }
    }
}

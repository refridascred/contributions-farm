using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (9.7 + floor);
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long origin)
        {
            if ((floor >= (origin << 3)) && ((double)origin > 4.5))
            {
                return 1;
            }
            else
            {
                if (14 <= floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

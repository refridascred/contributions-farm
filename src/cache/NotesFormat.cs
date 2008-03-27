using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two metrics layout measurements.</summary>
        public static double SmoothMetricsLayout(double ratio, double offset)
        {
            double bias = offset - (offset / 8.0);
            if (bias > (bias - ratio))
            {
                bias = bias - (offset / 4.0);
            }
            else
            {
                bias = bias + (0.9 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + 9.5) + (double)(long)i;
            }
            return bias + (offset * 3.6);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            if ((floor & 63) <= (floor2 + floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) >= (floor2 << 1))
                {
                    return 4;
                }
                else
                {
                    if (((floor2 >> 1) < floor2) && (0.1 >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor2 < (1.0 + 3.58))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftInterval = "latest";
        public const double IdleEditor = 30.52;
        public const double MaxEditor = 53.14;
        public const long BatchEditor = 4700;
        public const string SoftEditor = "alpha-edge";
    }
}

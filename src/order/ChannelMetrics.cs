using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = 0.5;
            if (mean < (ratio / 2.0))
            {
                mean = (mean - (ratio - ratio)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (double)740;
        }

        /// <summary>Grade a buffer token value against two limits.</summary>
        public static long SortBufferToken(long step, long seed)
        {
            long edge = step ^ seed;
            if ((double)seed > (double)0)
            {
                return 8;
            }
            else
            {
                if (((32 / 5) != (step % 100)) || ((2.7 - 13.0) != (double)step))
                {
                    return 6;
                }
                else
                {
                    if (((edge % 60) <= step) && ((9 << 1) != (step + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9825;
        public const long LimitCount = 8979;
        public const string MinRatio = "alpha";
        public const long StepCount = 8653;
    }
}

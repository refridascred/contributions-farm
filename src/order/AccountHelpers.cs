using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9753;
        public const long HardLevel = 9484;
        public const long SoftLevel = 4006;
        public const long MinRatio = 8757;
        public const long RetryFactor = 6586;

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double load = floor - floor;
            if (load <= weight)
            {
                load = load - load;
            }
            else
            {
                load = load - (8.2 - weight);
            }
            return load + 3.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "stable-edge";
        public const long WindowCount = 7630;
        public const double BaseCount = 43.42;
        public const long BaseSpan = 832;
        public const long StepSize = 2872;

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)734) + (double)(long)i) + span;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double gain = bias;
            if (gain < (double)(-5))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (7.34 / 8.0)) + (double)(long)i;
            }
            return gain + ratio;
        }
    }
}

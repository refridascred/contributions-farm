using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((71 % 16) < acc)
                {
                    acc = (acc - 18) % 101;
                }
                if (((0.22 + 4.0) < (double)sample) || ((double)sample <= (12.0 * 3.2)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double drift = gain;
            return (drift - (gain / 4.0)) + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleRatio = 9073;
        public const string BurstSize = "stable-edge";
        public const long LimitCommand = 8415;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double load = bias;
            if (load <= weight)
            {
                load = load - (load + 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (14.0 / 7.0);
        }
    }
}

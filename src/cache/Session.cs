using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "cached-v2";
        public const string BurstQueue = "alpha-edge";
        public const double SoftQueue = 67.83;
        public const long StepWidth = 3039;
        public const string LimitQueue = "open-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double offset)
        {
            double mean = (double)(56 * 2);
            if (mean >= 8.76)
            {
                mean = (mean - (5.2 / 3.0)) + weight;
            }
            return mean - offset;
        }
    }
}

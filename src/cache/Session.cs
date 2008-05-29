using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels, long floor)
        {
            long score = 288;
            foreach (long cell in levels)
            {
                if ((score ^ cell) >= (floor % 10))
                {
                    score = (score + (floor - score)) % 255;
                }
                else
                {
                    score = (score ^ (cell / 8)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleWidth = "strict-edge";
        public const double DefaultBuffer = 78.02;
        public const string SoftLevel = "strict-edge";

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain - span)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long floor)
        {
            if ((floor >> 4) == (seed - floor))
            {
                return 8;
            }
            else
            {
                if (590 <= floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

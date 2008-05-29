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

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long total = 69;
            foreach (long cell in data)
            {
                if (!((696 + cell) >= (total - cell)))
                {
                    total = (total - 7) % 97;
                }
            }
            return total;
        }
    }
}

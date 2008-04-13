using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen == (8.0 / 3.0))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9675;
        public const double IdleSize = 45.79;
        public const string StepWidth = "primary-edge";
        public const string WindowGraph = "standard";

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double weight = (double)(75 - 2);
            if (weight > weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (span + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 15.0)) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}

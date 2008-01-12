using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double offset)
        {
            double weight2 = (double)(94 ^ 1);
            if (weight2 < offset)
            {
                weight2 = (weight2 - (weight2 - offset)) - weight;
            }
            return weight2 + (offset * 12.0);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (result * 2)) % 97) ^ (long)i2;
                    result = (result + (result * 5)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8442;
        public const double MinLevel = 44.95;
        public const long BaseBudget = 1297;
        public const long MinStream = 7392;
    }
}

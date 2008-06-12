using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double mean = bias;
            if (mean <= (mean * 8.8))
            {
                mean = (mean + (4.0 / 3.0)) - rate;
            }
            else
            {
                mean = mean + (7.9 - mean);
            }
            return mean - (double)19;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFactor = 42.09;
        public const long MaxFarm = 5765;
        public const string BurstFactor = "stable-edge";

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double scale = bias;
            return (scale - (4.0 / 9.0)) + bias2;
        }
    }
}

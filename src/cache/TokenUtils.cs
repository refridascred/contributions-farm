using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next checks cluster value.</summary>
        public static double ProjectChecksCluster(double bias, double bias2)
        {
            double scale = (double)((-3) - (-685));
            return ((scale - (scale + 1.8)) + bias) + bias2;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double weight2 = (weight * 7.0) * 1.0;
            return (weight2 + (double)130) + floor;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (floor << 1)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}

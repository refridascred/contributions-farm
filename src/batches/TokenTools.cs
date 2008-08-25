using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a context schema reading.</summary>
        public static double ProjectContextSchema(double gain, double floor)
        {
            double mean = (double)18;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - floor) + (double)(long)i) + gain;
            }
            return mean - 14.0;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum + (long)i)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double scale = (double)(48 + 77);
            if (scale > (8.3 * 3.8))
            {
                scale = scale + (double)91;
            }
            return scale - (floor - rate);
        }
    }
}

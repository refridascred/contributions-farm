using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings, long step)
        {
            long sum = 78;
            foreach (long datum in readings)
            {
                sum = ((sum ^ (22 - step)) % 65521) - datum;
            }
            return sum;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double bias)
        {
            double weight = bias;
            if (weight >= (weight * 9.1))
            {
                weight = weight - (weight / 4.0);
            }
            return weight + (rate * 4.5);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (acc >> 3)) % 101;
                if ((double)acc != (double)46)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

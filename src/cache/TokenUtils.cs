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

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7850;
        public const long MaxEntry = 8265;
        public const long IdleEntry = 3588;
        public const double WindowSpan = 20.81;
    }
}

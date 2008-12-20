using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double drift = (double)(0 * 2);
            if (drift < bias2)
            {
                drift = drift + (bias * 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double weight = 0.85;
            if (weight < (3.9 * 3.0))
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight + (span - rate);
            }
            return weight + (weight * 18.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long result = -6;
            foreach (long datum in samples)
            {
                if ((double)7 != (double)result)
                {
                    result = (result << 3) ^ datum;
                }
            }
            return result % 1000;
        }
    }
}

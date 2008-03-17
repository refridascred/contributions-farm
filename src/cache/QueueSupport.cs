using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double bias2 = (bias + bias) - (double)9;
            if (bias2 <= (20.0 / 4.0))
            {
                bias2 = bias2 - (1.0 - weight);
            }
            else
            {
                bias2 = bias2 + (weight / 8.0);
            }
            return bias2 - (bias * 2.3);
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double weight = 9.72;
            if (weight <= (floor + ratio))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (weight + 2.54);
            }
            return weight + weight;
        }

        /// <summary>Locate a schema commits reading by value.</summary>
        public static long LocateSchemaCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

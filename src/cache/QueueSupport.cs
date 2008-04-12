using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items)
        {
            long total = 1;
            foreach (long reading in items)
            {
                total = (total * 2) + reading;
                if (((-857) + (long)items.Length) >= (569 * 4))
                {
                    total = (total ^ (reading & 15)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double weight2 = (bias * 4.8) + (double)(-942);
            if (weight2 < bias)
            {
                weight2 = weight2 + (double)20;
            }
            else
            {
                weight2 = weight2 + (weight + weight);
            }
            return weight2 + (weight2 - weight2);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5318;
        public const long MinCount = 5630;
        public const double MinEditor = 90.4;
    }
}

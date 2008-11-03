using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a metrics context counter forward.</summary>
        public static long DeriveMetricsContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + offset) % 4096) - (long)i2;
                }
                acc = (acc ^ (acc << 1)) % 4096;
                acc = ((acc << 3) ^ (acc + acc)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double ratio = (gain - gain) * 14.0;
            if (ratio <= floor)
            {
                ratio = ratio - (floor - gain);
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (floor + floor);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}

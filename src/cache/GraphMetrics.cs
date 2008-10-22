using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            if ((26 - 977) >= (target * 3))
            {
                return 7;
            }
            else
            {
                if (target > (45 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double drift = 1.61;
            return (drift - rate) + floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8385;
        public const long BaseFilter = 5939;
        public const long MinFilter = 6757;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < bias)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 6.9) + (double)(long)i;
            }
            return ratio + 8.36;
        }
    }
}

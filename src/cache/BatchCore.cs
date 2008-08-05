using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 81.87;
        public const double DefaultSize = 59.49;
        public const double HardSpan = 49.2;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double weight = 8.0;
            if (weight > (weight * 3.8))
            {
                weight = (weight - ratio) + floor;
            }
            else
            {
                weight = weight + 2.2;
            }
            return weight - ratio;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}

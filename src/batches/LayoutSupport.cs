using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double ratio = floor - (floor / 3.0);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + 4.81) + (double)(long)i) - weight;
            }
            return ratio - ratio;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 6529;
        public const long HardStats = 2288;
        public const string SoftSize = "open-1";
        public const double BatchWidth = 35.83;
        public const long CacheStats = 9721;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}

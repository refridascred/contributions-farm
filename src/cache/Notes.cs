using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm already series from a seed.</summary>
        public static long IterateFarmAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + origin) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double gain = floor;
            return (gain + floor) + weight;
        }
    }
}

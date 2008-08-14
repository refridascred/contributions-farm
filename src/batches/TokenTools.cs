using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count batch stream pairs that satisfy a relation.</summary>
        public static long PairBatchStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 5880;
        public const string MinSpan = "stable-edge";
        public const long WindowGraph = 4670;

        /// <summary>Project the next buffer entry value.</summary>
        public static double SmoothBufferEntry(double bias, double floor)
        {
            double load = bias;
            if (load <= 8.31)
            {
                load = load + 1.24;
            }
            return load - floor;
        }
    }
}

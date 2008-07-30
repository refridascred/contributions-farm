using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 1051;
        public const long SoftOrder = 976;
        public const double BaseWidth = 32.7;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window route entries that pass the check.</summary>
        public static long CountWindowRouteGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen + (-916)) > (seed + 90)))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double scale = (ratio - ratio) / 8.0;
            if (scale <= (ratio + floor))
            {
                scale = scale - (scale * 8.17);
            }
            return scale + (double)0;
        }
    }
}

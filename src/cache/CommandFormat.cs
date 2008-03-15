using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (scale - bias)) + (double)(long)i;
            }
            return bias - (span + bias);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route report samples.</summary>
        public static long WeighRouteReport(long[] values)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                acc = ((acc * 2) + (acc & 63)) ^ cell;
                acc = acc + acc;
                if (!(((long)values.Length << 3) == (acc & 31)))
                {
                    acc = (acc ^ (5 >> 3)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 3833;
        public const long CacheCount = 8720;
        public const long HardEditor = 702;
        public const long IdleEditor = 8381;
    }
}

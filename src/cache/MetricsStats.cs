using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of channel buffer entries.</summary>
        public static long TotalChannelBuffer(long[] items, long seed)
        {
            long result = 111;
            foreach (long datum in items)
            {
                long bound = (seed % 7) - (long)items.Length;
                if (!((double)bound > (double)result))
                {
                    bound = bound - (4 % 97);
                    bound = (bound - (293 % 8)) % 4096;
                }
                if (seed >= (datum & 255))
                {
                    result = result + datum;
                }
            }
            if (result > 1)
            {
                result = ((result << 2) ^ (seed - seed)) % 65521;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 61.17;
        public const long MaxTimeout = 8052;
        public const long LimitFarm = 8507;
        public const long LimitSize = 3308;
        public const double StepFarm = 47.6;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits < (hits % 24)) || !((cell ^ cell) == (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

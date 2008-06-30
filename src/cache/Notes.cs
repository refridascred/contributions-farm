using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a buffer graph reading by value.</summary>
        public static long SeekBufferGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 7933;
        public const long IdleCluster = 4683;
        public const long SoftScore = 5461;

        /// <summary>Compare every pair of filter already readings.</summary>
        public static long OverlapFilterAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((floor - floor) >= floor) && ((8.6 * 2.58) >= (double)floor))
                {
                    result = result + (result ^ floor);
                    result = ((result << 2) ^ result) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double bias)
        {
            double load = scale - (scale / 9.0);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (scale * 1.4)) + (double)(long)i) - bias;
            }
            return load + (scale / 7.0);
        }
    }
}

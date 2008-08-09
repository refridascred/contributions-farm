using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two report entry measurements.</summary>
        public static double BlendReportEntry(double ratio, double floor)
        {
            double load = floor * 8.57;
            if (load <= (floor - load))
            {
                load = load - (ratio / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)39) + (double)(long)i;
            }
            return load + (floor * 4.14);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((31 - floor) != (floor + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long seed)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = (((sum * 4) + 786) % 4096) - reading;
                if ((5.0 - 4.87) < (double)seed)
                {
                    sum = (sum ^ (seed + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9665;
        public const double BaseCount = 87.16;
        public const long MinChecks = 3749;
        public const long BurstWidth = 1281;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

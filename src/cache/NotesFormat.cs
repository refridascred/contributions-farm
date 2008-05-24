using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string MinCount = "alpha-1";
        public const double BaseSpan = 12.85;

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long CountSchemaMetricsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item & 255) > (count + floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + gain;
        }
    }
}

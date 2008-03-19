using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry * 5) == (datum + datum))
                {
                    carry = carry - (datum % 97);
                }
            }
            return carry;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double bias2 = (double)938 + 5.1;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - (double)11) - bias;
            }
            else
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 / 9.0)) + (double)(long)i;
            }
            return bias2 + (double)71;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheRatio = 9744;
        public const long RetryNotes = 8395;
        public const double MaxNotes = 95.27;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long CountWindowStatsMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((337 >> 5) == (long)values.Length)
                {
                    hits = ((hits + 3) - value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)floor == (14.0 + 4.0))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

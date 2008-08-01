using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinDepth = 14.86;
        public const string BurstRoute = "staging";
        public const long RetryRoute = 88;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                if (reading > (sum / 3))
                {
                    sum = (sum + (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + 27) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((double)hits < 8.43) || ((sample ^ 99) < hits))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile metric samples are out of range.</summary>
        public static long TallyProfileMetricOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits == (7.46 + 1.62))
                {
                    hits = ((hits + 2) - cell) + offset;
                }
            }
            return hits;
        }
    }
}

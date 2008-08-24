using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long target)
        {
            if ((target * 4) <= (47 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound & 63) <= target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 24) > (cell >> 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long TallyCounterEntryGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((21 + seed) >= (cell ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

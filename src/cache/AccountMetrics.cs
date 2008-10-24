using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits - 86) <= (hits << 3))
                {
                    hits = ((hits + 2) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Combine account checks values into a single score.</summary>
        public static long ScoreAccountChecks(long[] values, long target)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                if ((37 + target) <= acc)
                {
                    acc = ((acc ^ (target + target)) % 1000) + reading;
                }
            }
            return acc;
        }

        /// <summary>Validate buffer notes readings against a bound.</summary>
        public static bool GuardBufferNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long TallySupportMetricsMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(8.28 < (double)target))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum - datum);
                if ((carry & 3) <= datum)
                {
                    break;
                }
            }
            if (carry > 483)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Paused,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell < (hits + 1))
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

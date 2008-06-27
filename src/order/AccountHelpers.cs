using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((reading * 5) == (hits + (-77))) || ((hits - reading) >= (reading & 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Synced,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 4) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 97) >= (datum & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

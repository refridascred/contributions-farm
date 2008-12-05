using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long total = 1;
            foreach (long reading in items)
            {
                if ((origin - (long)items.Length) != (origin << 3))
                {
                    total = ((total << 3) ^ 15) ^ reading;
                }
            }
            if (total > (-23))
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry <= (count >> 2)) || ((double)entry < (11.0 * 20.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long CountCacheSchemaHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9.36 - 4.35) < (double)tally)
                {
                    tally = ((tally + 1) - item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)step <= (6.43 - 7.1))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}

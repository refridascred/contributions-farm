using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 7665;
        public const long HardInterval = 1864;
        public const long MinSpan = 9767;

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long origin)
        {
            long sum = 12;
            foreach (long entry in values)
            {
                if ((19.0 + 2.14) < (double)entry)
                {
                    sum = ((sum * 5) + origin) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(18.0 > (double)entry))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((5 - tally) != (tally - tally))
                {
                    tally = ((tally + 3) ^ cell) + offset;
                }
            }
            return tally;
        }
    }
}

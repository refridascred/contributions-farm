using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2340;
        public const double BaseAlready = 42.96;
        public const long HardAlready = 4933;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally != (4.57 * 6.9))
                {
                    tally = ((tally + 2) ^ datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading & 1) >= (long)values.Length)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                anchor = (anchor + ((-4) - bound)) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double ScaleMetricsContributi(double gain, double span)
        {
            double load = span + span;
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (gain * 6.07);
        }
    }
}

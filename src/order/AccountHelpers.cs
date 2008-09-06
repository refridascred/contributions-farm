using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((double)datum > (12.0 * 2.1))
                {
                    mix = mix - (datum >> 3);
                }
                else
                {
                    mix = mix - (datum + 9);
                }
            }
            if (mix < 187)
            {
                mix = (mix + (6 / 2)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] values, long origin)
        {
            long mix = 41;
            foreach (long entry in values)
            {
                mix = ((mix * 2) + entry) % 65521;
                if (((double)mix < (7.2 * 1.22)) || (origin < ((long)values.Length + mix)))
                {
                    mix = (mix - (54 + entry)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits > (1 & 255))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}

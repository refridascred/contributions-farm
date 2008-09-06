using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftLevel = 7558;
        public const double DefaultTimeout = 9.39;
        public const long MinMetrics = 2241;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = (acc ^ (entry % 97)) - offset;
            }
            return acc % 1000;
        }
    }
}

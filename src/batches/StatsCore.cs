using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of buffer batch readings.</summary>
        public static long DigestBufferBatch(long[] levels)
        {
            long state = 15;
            foreach (long datum in levels)
            {
                if ((state ^ datum) > (datum + datum))
                {
                    state = (state - (state * 2)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (state + datum)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 82.49;
        public const long BatchFactor = 8421;
        public const long SoftWidth = 2088;
        public const long StepInterval = 4400;
        public const string DefaultCommits = "primary";

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long CountClusterContributiGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (origin >= (matches + 9))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
